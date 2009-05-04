using System;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Administrator.EventArgsReferences;
using Administrator.Frames;
using Administrator.Objects;
using Administrator.References;
using DevExpress.XtraBars;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;
using DevExpress.XtraGrid.Views.Base;
using DevExpress.XtraGrid.Views.Grid.ViewInfo;
using log4net;

namespace Administrator.Controls
{
    public partial class EventListControl : XtraUserControl
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(EventListControl));

        public event EventUpdatedEventHandler EventUpdated;
        public event CurrentEventChangedEventHandler CurrentEventChanged;
        public event EventCloseEventHandler EventClosed;
        public event DataSourceNeededEventHandler AllPersonsSourceNeeded;
        public event DataSourceNeededEventHandler AllOrganizationsSourceNeeded;

        public EventListControl()
        {
            InitializeComponent();
            UpdateMenuState();
        }

        public Event CurrentEvent
        {
            get
            {
                if (MainView.GetFocusedRow() == null) return null;

                return Entity.Assign<Event>(((DataRowView) MainView.GetFocusedRow()).Row);
            }
        }

        public Object DataSource
        {
            get { return EventGrid.DataSource; }
            set { EventGrid.DataSource = value; }
        }

        public void FocusRow(Guid eventId)
        {
            int handle = -1;

            for (int i = 0; i < MainView.RowCount; i++)
            {
                if ((Guid)MainView.GetRowCellValue(i, "event_id") == eventId)
                {
                    handle = i;
                    break;
                }
            }

            if (handle != -1)
            {
                if (MainView.FocusedRowHandle != handle)
                {
                    MainView.FocusedRowHandle = handle;
                    OnEventChanged(new EventChangedEventArgs(CurrentEvent));
                }
            }
        }

        protected void OnEventUpdated(EventUpdatedEventArgs e)
        {
            if (EventUpdated != null) EventUpdated(this, e);
        }

        protected void OnEventChanged(EventChangedEventArgs e)
        {
            UpdateMenuState();

            if (CurrentEventChanged != null) CurrentEventChanged(this, e);
        }

        protected void OnEventClosed(EventCloseEventArgs e)
        {
            if (EventClosed != null) EventClosed(this, e);
        }

        private object OnAllPersonsSourceNeeded(DataSourceNeededEventArgs e)
        {
            if (AllPersonsSourceNeeded != null) AllPersonsSourceNeeded(this, e);
            return e.DataSource;
        }

        private object OnAllOrganizationsListNeeded(DataSourceNeededEventArgs e)
        {
            if (AllOrganizationsSourceNeeded != null) AllOrganizationsSourceNeeded(this, e);
            return e.DataSource;
        }

        private void UpdateMenuState()
        {
            MenuEdit.Enabled = CurrentEvent != null;
            CloseEventButton.Enabled = CurrentEvent != null && CurrentEvent.State == EventStates.Open;
        }

        private void EditEventCloseEventDetails(bool isNewEvent)
        {
            if(isNewEvent)
            {
                EditEventDetails(true);
            }
            else
            {
                if (CurrentEvent == null) return;

                if (CurrentEvent.State == EventStates.Open)
                {
                    EditEventDetails(false);

                }
                else
                {
                    EditCloseDetails();
                }
            }
            UpdateMenuState();
        }

        private void EditCloseDetails()
        {
            if(CurrentEvent == null) return;

            using (var form = new EventClosedDetailsFrame())
            {
                form.Event = CurrentEvent;
                form.PersonsDataSource = OnAllPersonsSourceNeeded(new DataSourceNeededEventArgs(null));
                form.OrganizationsDataSource = OnAllOrganizationsListNeeded(new DataSourceNeededEventArgs(null));

                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnEventUpdated(new EventUpdatedEventArgs(form.Event));
                }
            }
        }

        private void EditEventDetails(bool isNewEvent)
        {
            using (var form = new EventDetailsForm())
            {
                if(!isNewEvent)
                {
                    form.Event = CurrentEvent;
                }

                form.PersonsDataSource = OnAllPersonsSourceNeeded(new DataSourceNeededEventArgs(null));
                form.OrganizationsDataSource = OnAllOrganizationsListNeeded(new DataSourceNeededEventArgs(null));

                if (form.ShowDialog() == DialogResult.OK)
                {
                    OnEventUpdated(new EventUpdatedEventArgs(form.Event));
                    if(isNewEvent) FocusRow(form.Event.EventId);
                }
            }


        }

        private void MenuNew_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditEventCloseEventDetails(true);
        }

        private void MainView_FocusedRowChanged(object sender, FocusedRowChangedEventArgs e)
        {
            OnEventChanged(new EventChangedEventArgs(CurrentEvent));
        }

        private void TypeTextEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if (e == null || e.Value == null) return;
            try
            {
                e.DisplayText = EventTypeReference.GetEventReference((EventTypes) e.Value);
            }catch (Exception)
            {
                
            }
        }

        private void CloseEventButton_ItemClick(object sender, ItemClickEventArgs e)
        {
            using (var frame = new EventCloseFrame())
            {
                EventStates eventState;

                switch (frame.ShowDialog())
                {
                    case DialogResult.OK:
                        eventState = EventStates.Close;
                        break;
                    case DialogResult.Abort:
                        eventState = EventStates.Refuse;
                        break;
                    case DialogResult.Cancel:
                        return;
                    default:
                        throw new ArgumentOutOfRangeException();
                }

                OnEventClosed(new EventCloseEventArgs(CurrentEvent.EventId, eventState, frame.CashPrice, frame.NonCashPrice, frame.Loss, frame.Review));
            }
            UpdateMenuState();
        }

        private void MainView_DoubleClick(object sender, EventArgs e)
        {
            EditEventCloseEventDetails(false);
        }

        private void MenuEdit_ItemClick(object sender, ItemClickEventArgs e)
        {
            EditEventCloseEventDetails(false);
        }

        private void MainView_CustomDrawCell(object sender, RowCellCustomDrawEventArgs e)
        {
            if (e.CellValue == null) return;

            GridCellInfo info = (GridCellInfo) e.Cell;

            try
            {
                bool focused = (info.State & GridRowCellState.Focused) == GridRowCellState.Focused;

                switch ((EventStates)info.RowInfo.Cells[MainView.Columns["state"]].ViewInfo.EditValue)
                {
                    case EventStates.Open:
                        info.Appearance.ForeColor = focused ? Color.LightBlue : Color.DarkBlue;
                        break;
                    case EventStates.Close:
                        info.Appearance.ForeColor = focused?Color.LightGreen:Color.DarkGreen;
                        break;
                    case EventStates.Refuse:
                        info.Appearance.ForeColor = focused ? Color.LightPink : Color.DarkRed;
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
                }
                if (info.ColumnInfo.Column.Name == "state")
                {
                   e.DisplayText = EventStateReference.GetEventStateReference((EventStates) e.CellValue);
                }
            }
            catch
            {
                return;
            }
        }

        private void StateTextEdit_CustomDisplayText(object sender, CustomDisplayTextEventArgs e)
        {
            if(e == null || e.Value == null) return;
            try
            {
                e.DisplayText = EventStateReference.GetEventStateReference((EventStates)e.Value);
            }
            catch (Exception)
            {
                return;
            }
            
        }
    }

    public delegate void EventUpdatedEventHandler(Object sender, EventUpdatedEventArgs e);

    public delegate void EventCloseEventHandler(Object sender, EventCloseEventArgs e);

    public delegate void CurrentEventChangedEventHandler(Object sender, EventChangedEventArgs e);

    public class EventUpdatedEventArgs : EventArgs
    {
        public EventUpdatedEventArgs(Event ev)
        {
            Event = ev;
        }

        public Event Event { get; private set; }
    }

    public class EventChangedEventArgs : EventUpdatedEventArgs
    {
        public EventChangedEventArgs(Event ev)
            : base(ev)
        {
        }
    }

    public class EventCloseEventArgs : EventArgs
    {
        public EventCloseEventArgs(Guid EventId, EventStates state, Decimal cashPrice, Decimal nonCashPrice, Decimal loss, string overview)
        {
            this.EventId = EventId;
            State = state;
            CashPrice = cashPrice;
            NonCashPrice = nonCashPrice;
            Loss = loss;
            Overview = overview;
        }

        public Guid EventId { get; private set; }
        public EventStates State { get; private set; }
        public decimal CashPrice { get; private set; }
        public decimal NonCashPrice { get; set; }
        public decimal Loss { get; private set; }
        public string Overview { get; private set; }
    }
}
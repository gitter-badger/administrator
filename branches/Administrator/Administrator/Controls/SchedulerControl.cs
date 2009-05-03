using System;
using System.Collections.Generic;
using System.Data;
using System.Drawing;
using System.Windows.Forms;
using Administrator.EventArgsReferences;
using Administrator.Frames;
using Administrator.Objects;
using DevExpress.Utils.Menu;
using DevExpress.XtraBars;
using DevExpress.XtraBars.Docking;
using DevExpress.XtraEditors;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.Drawing;

namespace Administrator.Controls
{
    public partial class SchedulerControl : XtraUserControl
    {
        public event ServiceUpdatedEvintHandler ServiceUpdated;
        public event EventUpdatedEventHandler EventUpdated;
        public event AppointmentChangedEventHandler AppintmentAdded;
        public event AppointmentChangedEventHandler AppintmentDelated;
        public event AppointmentChangedEventHandler AppintmentModified;
        public event ServiceIdsForEventsNeededEventHandler ServiceIdsNeededForEvent;
        public event EventCloseEventHandler EventClosed;
        public event DataSourceNeededEventHandler AllPersonsTableNeeded;
        public event DataSourceNeededEventHandler AllOrganizationsTableNeeded;

        private int suspendLayout;

        public SchedulerControl()
        {
            InitializeComponent();

            Scheduler.Start = DateTime.Now;

            UpdateMenuState();
            ApplyFilterByEvent();
        }

        public object AppintmentsDataSource
        {
            get { return schedulerStorage.Appointments.DataSource; }
            set
            {
                schedulerStorage.BeginUpdate();
                schedulerStorage.Appointments.DataSource = value;
                schedulerStorage.EndUpdate();
            }
        }

        public Object ServicesDataSource
        {
            get { return ServiceControl.DataSource; }
            set { ServiceControl.DataSource = value; }
        }

        public Object EventDataSource
        {
            get { return EventList.DataSource; }
            set { EventList.DataSource = value; }
        }

        public List<Service> SchedulerResuources
        {
            set
            {
                Scheduler.BeginUpdate();
                schedulerStorage.BeginUpdate();
                schedulerStorage.Resources.BeginUpdate();
                // schedulerStorage.Resources.Clear();

                for (int i = 0; i < value.Count; i++)
                {
                    AddSchedulerResource(i, value[i].Name, value[i].ServiceId);
                }

                Scheduler.Visible = value.Count != 0;

                Scheduler.GroupType = SchedulerGroupType.Resource;

                schedulerStorage.Resources.EndUpdate();
                schedulerStorage.EndUpdate();
                Scheduler.EndUpdate();
            }
        }

        public bool IsLayoutSuspended
        {
            get { return suspendLayout > 0; }
        }

        protected void OnEventUpdated(EventUpdatedEventArgs e)
        {
            if (EventUpdated != null) EventUpdated(this, e);
        }

        protected void OnServiceUpdated(ServiceUpdatedEventArgs e)
        {
            if (ServiceUpdated != null) ServiceUpdated(this, e);
        }

        protected void OnAppintmentModified(AppintmentChangedEventArgs e)
        {
            if (AppintmentModified != null) AppintmentModified(this, e);
        }

        protected void OnAppintmentAdded(AppintmentChangedEventArgs e)
        {
            if (AppintmentAdded != null) AppintmentAdded(this, e);
        }

        protected void OnAppintmentDelated(AppintmentChangedEventArgs e)
        {
            if (AppintmentDelated != null) AppintmentDelated(this, e);
        }

        protected void OnServiceIdsForEventNeeded(NeedServicesToEventEventArgs e, out List<Guid> serviceIds)
        {
            if (ServiceIdsNeededForEvent != null) ServiceIdsNeededForEvent(this, e);

            serviceIds = e.ServiceIds;
        }

        protected void OnEventClosed(EventCloseEventArgs e)
        {
            if (EventClosed != null) EventClosed(this, e);
        }

        protected object OnAllPersonsTableNeeded(DataSourceNeededEventArgs e)
        {
            if (AllPersonsTableNeeded != null) AllPersonsTableNeeded(this, e);
            return e.DataSource;
        }

        protected object OnAllOrganizationsSourceNeeded(DataSourceNeededEventArgs e)
        {
            if (AllOrganizationsTableNeeded != null) AllOrganizationsTableNeeded(this, e);
            return e.DataSource;
        }

        private void AddSchedulerResource(int index, string caption, Guid serviceID)
        {
            
            var r = new Resource(serviceID, caption);
            r.Color = Scheduler.ResourceColorSchemas.GetSchema(index).CellLight;
            for (int i = 0; i < schedulerStorage.Resources.Count; i++)
            {
                if ((Guid)schedulerStorage.Resources[i].Id == (Guid)r.Id)
                {
                    schedulerStorage.Resources[i].Caption = r.Caption;
                    return;
                }
            }
            r.Visible = false;
            schedulerStorage.Resources.Add(r);
        }

        private void EnableDisablePanel(DockPanel panel, bool enable)
        {
            if (enable)
            {
                panel.Show();
                return;
            }

            panel.Close();
        }

        private void SetResourceVisibility(IEnumerable<Service> services)
        {
            if (services == null) return;

            bool hasActiveResource = false;
            Scheduler.BeginUpdate();
            schedulerStorage.BeginUpdate();
            schedulerStorage.Resources.BeginUpdate();
            for (int i = 0; i < schedulerStorage.Resources.Count; i++)
            {
                bool enabled = false;

                foreach (Service service in services)
                {
                    if (((Guid)schedulerStorage.Resources[i].Id) == service.ServiceId)
                    {
                        enabled = true;
                        break;
                    }
                }
                schedulerStorage.Resources[i].Visible = enabled;
                hasActiveResource |= enabled;
            }
            schedulerStorage.Resources.EndUpdate();
            schedulerStorage.EndUpdate();
            Scheduler.Visible = hasActiveResource;
            Scheduler.EndUpdate();
        }

        private void ConfugureMenuElements(PreparePopupMenuEventArgs e)
        {
            SchedulerMenuItem item = e.Menu.GetMenuItemById(SchedulerMenuItemId.NewAppointment,true);
            if (item != null)
            {
                item.Enabled = EventList.CurrentEvent != null;
                item.Caption = "Новое событие";
            }

            item = e.Menu.GetMenuItemById(SchedulerMenuItemId.DeleteAppointment,true);
            if (item != null) { item.Caption = "Удалить"; }

            item = e.Menu.GetMenuItemById(SchedulerMenuItemId.OpenAppointment,true);
            if (item != null) item.Caption = "Изменить";

            item = e.Menu.GetMenuItemById(SchedulerMenuItemId.GotoThisDay,true);
            if (item != null) item.Caption = "Перейти к этой дате";

            e.Menu.RemoveMenuItem(SchedulerMenuItemId.LabelSubMenu, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.StatusSubMenu, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewAllDayEvent, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringAppointment, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.NewRecurringEvent, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoDate, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.GotoToday, true);
            e.Menu.RemoveMenuItem(SchedulerMenuItemId.SwitchViewMenu, true);
        }

        private void SuspendControl()
        {
            suspendLayout++;
        }

        private void ResumeControl()
        {
            suspendLayout = suspendLayout > 0 ? suspendLayout - 1 : 0;
        }

        private void UpdateMenuState()
        {
            FilterByEvent.Enabled = EventList.CurrentEvent != null;
        }

        private List<EventServiceRelation> GetEventServiceRelationsFromArgs(PersistentObjectsEventArgs e)
        {
            List<EventServiceRelation> result = new List<EventServiceRelation>();

            foreach (Object o in e.Objects)
            {
                EventServiceRelation relation = GetEventServiceRelation(o);

                if(relation == null) continue;

                result.Add(relation);
            }

            return result;
        }

        private EventServiceRelation GetEventServiceRelation(object o)
        {
            Appointment appointment = o as Appointment;

            if (appointment == null) return null;

            Guid appId = (Guid)appointment.CustomFields["service_event_id"];

            return new EventServiceRelation
                       {

                           ServiceEventId = appId,
                           Description = appointment.Description,
                           EndDate = appointment.End,
                           StartDate = appointment.Start,
                           EventId = (Guid) appointment.CustomFields["event_id"],
                           ServiceId = (Guid) appointment.ResourceId
                       };
        }

        private void ApplyFilterByEvent()
        {
            schedulerStorage.BeginUpdate();
            schedulerStorage.Appointments.Filter = FilterByEvent.Down ? string.Format("[event_id] = '{0}'", EventList.CurrentEvent.EventId) : null;
            schedulerStorage.EndUpdate();
        }

        #region Event Handlers

        private void ServiceControl_ServiceUpdated(object sender, ServiceUpdatedEventArgs e)
        {
            OnServiceUpdated(e);
        }

        private void MenuPanels_Popup(object sender, EventArgs e)
        {
            MenuServices.Checked = !DockManager.HiddenPanels.Contains(ServicePanel);
            MenuDataNavigator.Checked = !DockManager.HiddenPanels.Contains(NavigationPanel);
            MenuEvents.Checked = !DockManager.HiddenPanels.Contains(EventPanel);
        }

        private void MenuServices_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            EnableDisablePanel(ServicePanel, ((BarCheckItem)e.Item).Checked);
        }

        private void MenuEvents_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            EnableDisablePanel(EventPanel, ((BarCheckItem)e.Item).Checked);
        }

        private void MenuDataNavigator_CheckedChanged(object sender, ItemClickEventArgs e)
        {
            EnableDisablePanel(NavigationPanel, ((BarCheckItem)e.Item).Checked);
        }

        private void ServiceControl_DataSourceChanged(object sender, EventArgs e)
        {
            SchedulerResuources = ServiceControl.AllServices;
        }

        private void ServiceControl_SelectedServiceChanged(object sender, SelectionChangedEventArgs e)
        {
            SetResourceVisibility(e.Selection);
        }

        private void EventList_EventUpdated(object sender, EventUpdatedEventArgs e)
        {
            OnEventUpdated(e);
        }

        private void EventList_CurrentEventChanged(object sender, EventChangedEventArgs e)
        {
            List<Guid> serviceIds = new List<Guid>();

            UpdateMenuState();

            if (EventList.CurrentEvent != null)
                OnServiceIdsForEventNeeded(new NeedServicesToEventEventArgs(EventList.CurrentEvent.EventId), out serviceIds);

            ServiceControl.SelectServices(serviceIds);

            ApplyFilterByEvent();
        }

        private void FilterByEvent_ItemClick(object sender, ItemClickEventArgs e)
        {
            ApplyFilterByEvent();
        }

        private void Scheduler_PreparePopupMenu(object sender, PreparePopupMenuEventArgs e)
        {
            ConfugureMenuElements(e);
        }

        private void Scheduler_EditAppointmentFormShowing(object sender, AppointmentFormEventArgs e)
        {

            if (EventList.CurrentEvent != null)
            {
                using (
                    CustomAppointmentForm form = new CustomAppointmentForm(Scheduler, e.Appointment,
                                                                           EventList.CurrentEvent))
                {
                    if (form.ShowDialog() == DialogResult.OK)
                    {

                    }
                }
            }
            e.Handled = true;
        }

        private void schedulerStorage_AppointmentsChanged(object sender, PersistentObjectsEventArgs e)
        {
            if (!IsLayoutSuspended)
                OnAppintmentModified(new AppintmentChangedEventArgs(GetEventServiceRelationsFromArgs(e)));
        }

        private void schedulerStorage_AppointmentsDeleted(object sender, PersistentObjectsEventArgs e)
        {
            if (!IsLayoutSuspended)
                OnAppintmentDelated(new AppintmentChangedEventArgs(GetEventServiceRelationsFromArgs(e)));
        }

        private void schedulerStorage_AppointmentsInserted(object sender, PersistentObjectsEventArgs e)
        {
            if (!IsLayoutSuspended)
                OnAppintmentAdded(new AppintmentChangedEventArgs(GetEventServiceRelationsFromArgs(e)));
        }

        private void Scheduler_CustomDrawAppointmentBackground(object sender, CustomDrawObjectEventArgs e)
        {
            AppointmentViewInfo aptViewInfo = e.ObjectInfo as AppointmentViewInfo;
            if (aptViewInfo == null)
                return;

            if (EventList.CurrentEvent == null) return;

            if ((Guid)aptViewInfo.Appointment.CustomFields["event_id"] == EventList.CurrentEvent.EventId)
            {
                Rectangle r = e.Bounds;
                Brush br = e.Cache.GetSolidBrush(Color.LightPink);
                using (Region rgn = new Region(Utils.CreateRoundedRectPath(r, 5)))
                {
                    e.Graphics.FillRegion(br, rgn);
                }
                r.Inflate(-5, -5);
                br = e.Cache.GetSolidBrush(aptViewInfo.Appearance.BackColor);
                using (Region rgn = new Region(Utils.CreateRoundedRectPath(r, 5)))
                {
                    e.Graphics.FillRegion(br, rgn);
                }
            }
            else
            {
                e.DrawDefault();
            }
            e.Handled = true;
        }

        private void EventList_EventClosed(object sender, EventCloseEventArgs e)
        {
            OnEventClosed(e);
        }

        private void schedulerStorage_AppointmentInserting(object sender, PersistentObjectCancelEventArgs e)
        {
            
        }

        private void schedulerStorage_AppointmentChanging(object sender, PersistentObjectCancelEventArgs e)
        {
            EventServiceRelation relation = GetEventServiceRelation(e.Object);

            if (EventList.CurrentEvent == null || relation == null || relation.EventId != EventList.CurrentEvent.EventId)
            {
                e.Cancel = true;
                return;
            }
        }

        private void schedulerStorage_AppointmentDeleting(object sender, PersistentObjectCancelEventArgs e)
        {
            EventServiceRelation relation = GetEventServiceRelation(e.Object);

            if (EventList.CurrentEvent == null || relation == null || relation.EventId != EventList.CurrentEvent.EventId)
            {
                e.Cancel = true;
                return;
            }
        }

        private void EventList_AllOrganizationsTableNeeded(object sender, DataSourceNeededEventArgs e)
        {
            e.DataSource = OnAllOrganizationsSourceNeeded(new DataSourceNeededEventArgs(e.DataSource));
        }
        private void EventList_AllPersonsTableNeeded(object sender, DataSourceNeededEventArgs e)
        {
            e.DataSource = OnAllPersonsTableNeeded(new DataSourceNeededEventArgs(e.DataSource));
        }
        #endregion
     }

    public delegate void AppointmentChangedEventHandler(Object sender, AppintmentChangedEventArgs e);

    public delegate void ServiceIdsForEventsNeededEventHandler(object sender, NeedServicesToEventEventArgs e);

    public class AppintmentChangedEventArgs : EventArgs
    {
        public AppintmentChangedEventArgs(List<EventServiceRelation> relations)
        {
            Relations = relations;
        }

        public List<EventServiceRelation> Relations { get; private set; }
    }

    public class NeedServicesToEventEventArgs : EventArgs
    {
        public NeedServicesToEventEventArgs(Guid eventId)
        {
            EventId = eventId;
        }

        public Guid EventId { get; private set; }
        public List<Guid> ServiceIds { get; set; }
    }
}
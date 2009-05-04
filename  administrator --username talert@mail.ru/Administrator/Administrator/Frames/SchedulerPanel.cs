using System;
using Administrator.Controls;
using Administrator.References;

namespace Administrator.Frames
{
    public partial class SchedulerPanel : ChildFrame
    {
        public SchedulerPanel()
        {
            InitializeComponent();
        }

        private void ShedulerPanel_Shown(object sender, EventArgs e)
        {
            ShedulerControl.ServicesDataSource = Document.AllServices;
            ShedulerControl.EventDataSource = Document.AllEvents;
            ShedulerControl.AppintmentsDataSource = Document.AllAppintments;
        }

        private void ShedulerControl_EventUpdated(object sender, EventUpdatedEventArgs e)
        {
            Document.UpdateEvent(e.Event);
            Document.UpdateEventList();
            Document.UpdateAppointments();
        }

        private void ShedulerControl_ServiceUpdated(object sender, ServiceUpdatedEventArgs e)
        {
            Document.UpdateServiceAndType(e.ServiceType, e.Service);
            Document.UpdateServiceTreeList();
        }

        private void ShedulerControl_AppintmentAdded(object sender, AppintmentChangedEventArgs e)
        {
            Document.UpdateEventServiceRelation(e.Relations);
        }

        private void ShedulerControl_AppintmentDelated(object sender, AppintmentChangedEventArgs e)
        {
            Document.DelateEventServiceRelation(e.Relations);
        }

        private void ShedulerControl_AppintmentModified(object sender, AppintmentChangedEventArgs e)
        {
            Document.UpdateEventServiceRelation(e.Relations);
        }

        private void ShedulerControl_ServiceIdsNeededForEvent(object sender, NeedServicesToEventEventArgs e)
        {
            e.ServiceIds = Document.GetServiceIdForEvent(e.EventId);
        }

        private void ShedulerControl_EventClosed(object sender, EventCloseEventArgs e)
        {
            Document.CloseEvent(e.EventId,e.State,e.CashPrice,e.NonCashPrice, e.Loss,e.Overview);
            Document.UpdateEventList();
            if (e.State == EventStates.Refuse) Document.UpdateAppointments();
        }

        private void ShedulerControl_AllOrganizationsSourceNeeded(object sender, EventArgsReferences.DataSourceNeededEventArgs e)
        {
            e.DataSource = Program.CurrentDataContext.AllOrganizations;
        }

        private void ShedulerControl_AllPersonsSourceNeeded(object sender, EventArgsReferences.DataSourceNeededEventArgs e)
        {
            e.DataSource = Program.CurrentDataContext.AllPersons;
        }
    }
}
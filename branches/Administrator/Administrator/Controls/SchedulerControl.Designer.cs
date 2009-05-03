namespace Administrator.Controls
{
    partial class SchedulerControl
    {
        /// <summary> 
        /// Required designer variable.
        /// </summary>
        private System.ComponentModel.IContainer components = null;

        /// <summary> 
        /// Clean up any resources being used.
        /// </summary>
        /// <param name="disposing">true if managed resources should be disposed; otherwise, false.</param>
        protected override void Dispose(bool disposing)
        {
            if (disposing && (components != null))
            {
                components.Dispose();
            }
            base.Dispose(disposing);
        }

        #region Component Designer generated code

        /// <summary> 
        /// Required method for Designer support - do not modify 
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            DevExpress.XtraScheduler.TimeRuler timeRuler3 = new DevExpress.XtraScheduler.TimeRuler();
            DevExpress.XtraScheduler.TimeRuler timeRuler4 = new DevExpress.XtraScheduler.TimeRuler();
            this.bar2 = new DevExpress.XtraBars.Bar();
            this.BarManager = new DevExpress.XtraBars.BarManager(this.components);
            this.bar1 = new DevExpress.XtraBars.Bar();
            this.MenuView = new DevExpress.XtraBars.BarSubItem();
            this.MenuPanels = new DevExpress.XtraBars.BarSubItem();
            this.MenuServices = new DevExpress.XtraBars.BarCheckItem();
            this.MenuEvents = new DevExpress.XtraBars.BarCheckItem();
            this.MenuDataNavigator = new DevExpress.XtraBars.BarCheckItem();
            this.FilterByEvent = new DevExpress.XtraBars.BarButtonItem();
            this.barDockControlTop = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlBottom = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlLeft = new DevExpress.XtraBars.BarDockControl();
            this.barDockControlRight = new DevExpress.XtraBars.BarDockControl();
            this.DockManager = new DevExpress.XtraBars.Docking.DockManager(this.components);
            this.ServicePanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel1_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.ServiceControl = new Administrator.Controls.ServiceControl();
            this.NavigationPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel2_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.DateNavigator = new DevExpress.XtraScheduler.DateNavigator();
            this.Scheduler = new DevExpress.XtraScheduler.SchedulerControl();
            this.schedulerStorage = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.EventPanel = new DevExpress.XtraBars.Docking.DockPanel();
            this.dockPanel3_Container = new DevExpress.XtraBars.Docking.ControlContainer();
            this.EventList = new Administrator.Controls.EventListControl();
            this.MenuNewEvent = new DevExpress.XtraBars.BarSubItem();
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).BeginInit();
            this.ServicePanel.SuspendLayout();
            this.dockPanel1_Container.SuspendLayout();
            this.NavigationPanel.SuspendLayout();
            this.dockPanel2_Container.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DateNavigator)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scheduler)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).BeginInit();
            this.EventPanel.SuspendLayout();
            this.dockPanel3_Container.SuspendLayout();
            this.SuspendLayout();
            // 
            // bar2
            // 
            this.bar2.BarName = "Main menu";
            this.bar2.DockCol = 0;
            this.bar2.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar2.OptionsBar.MultiLine = true;
            this.bar2.OptionsBar.UseWholeRow = true;
            this.bar2.Text = "Main menu";
            // 
            // BarManager
            // 
            this.BarManager.Bars.AddRange(new DevExpress.XtraBars.Bar[] {
            this.bar1});
            this.BarManager.DockControls.Add(this.barDockControlTop);
            this.BarManager.DockControls.Add(this.barDockControlBottom);
            this.BarManager.DockControls.Add(this.barDockControlLeft);
            this.BarManager.DockControls.Add(this.barDockControlRight);
            this.BarManager.DockManager = this.DockManager;
            this.BarManager.Form = this;
            this.BarManager.Items.AddRange(new DevExpress.XtraBars.BarItem[] {
            this.MenuView,
            this.MenuPanels,
            this.MenuServices,
            this.MenuEvents,
            this.MenuDataNavigator,
            this.MenuNewEvent,
            this.FilterByEvent});
            this.BarManager.MaxItemId = 7;
            // 
            // bar1
            // 
            this.bar1.BarName = "Tools";
            this.bar1.DockCol = 0;
            this.bar1.DockRow = 0;
            this.bar1.DockStyle = DevExpress.XtraBars.BarDockStyle.Top;
            this.bar1.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuView, true),
            new DevExpress.XtraBars.LinkPersistInfo(DevExpress.XtraBars.BarLinkUserDefines.PaintStyle, this.FilterByEvent, "", true, true, true, 0, null, DevExpress.XtraBars.BarItemPaintStyle.CaptionGlyph)});
            this.bar1.OptionsBar.AllowQuickCustomization = false;
            this.bar1.OptionsBar.DrawDragBorder = false;
            this.bar1.OptionsBar.UseWholeRow = true;
            this.bar1.Text = "Tools";
            // 
            // MenuView
            // 
            this.MenuView.Caption = "Вид";
            this.MenuView.Id = 0;
            this.MenuView.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuPanels)});
            this.MenuView.Name = "MenuView";
            // 
            // MenuPanels
            // 
            this.MenuPanels.Caption = "Панели";
            this.MenuPanels.Id = 1;
            this.MenuPanels.LinksPersistInfo.AddRange(new DevExpress.XtraBars.LinkPersistInfo[] {
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuServices),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuEvents),
            new DevExpress.XtraBars.LinkPersistInfo(this.MenuDataNavigator)});
            this.MenuPanels.Name = "MenuPanels";
            this.MenuPanels.Popup += new System.EventHandler(this.MenuPanels_Popup);
            // 
            // MenuServices
            // 
            this.MenuServices.Caption = "Услуги";
            this.MenuServices.Id = 2;
            this.MenuServices.Name = "MenuServices";
            this.MenuServices.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuServices_CheckedChanged);
            // 
            // MenuEvents
            // 
            this.MenuEvents.Caption = "Мероприятия";
            this.MenuEvents.Id = 3;
            this.MenuEvents.Name = "MenuEvents";
            this.MenuEvents.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuEvents_CheckedChanged);
            // 
            // MenuDataNavigator
            // 
            this.MenuDataNavigator.Caption = "Навигатор";
            this.MenuDataNavigator.Id = 4;
            this.MenuDataNavigator.Name = "MenuDataNavigator";
            this.MenuDataNavigator.CheckedChanged += new DevExpress.XtraBars.ItemClickEventHandler(this.MenuDataNavigator_CheckedChanged);
            // 
            // FilterByEvent
            // 
            this.FilterByEvent.ButtonStyle = DevExpress.XtraBars.BarButtonStyle.Check;
            this.FilterByEvent.Caption = "Фильтр по мероприятиям";
            this.FilterByEvent.Glyph = global::Administrator.Properties.Resources.funnel;
            this.FilterByEvent.Id = 6;
            this.FilterByEvent.Name = "FilterByEvent";
            this.FilterByEvent.ItemClick += new DevExpress.XtraBars.ItemClickEventHandler(this.FilterByEvent_ItemClick);
            // 
            // DockManager
            // 
            this.DockManager.Form = this;
            this.DockManager.RootPanels.AddRange(new DevExpress.XtraBars.Docking.DockPanel[] {
            this.ServicePanel,
            this.NavigationPanel,
            this.EventPanel});
            this.DockManager.TopZIndexControls.AddRange(new string[] {
            "DevExpress.XtraBars.BarDockControl",
            "System.Windows.Forms.StatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonStatusBar",
            "DevExpress.XtraBars.Ribbon.RibbonControl"});
            // 
            // ServicePanel
            // 
            this.ServicePanel.Controls.Add(this.dockPanel1_Container);
            this.ServicePanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Left;
            this.ServicePanel.ID = new System.Guid("bd1de7ce-8ded-43de-975c-aa8ade6bac4b");
            this.ServicePanel.Location = new System.Drawing.Point(0, 34);
            this.ServicePanel.Name = "ServicePanel";
            this.ServicePanel.Size = new System.Drawing.Size(248, 494);
            this.ServicePanel.Text = "Услуги";
            // 
            // dockPanel1_Container
            // 
            this.dockPanel1_Container.Controls.Add(this.ServiceControl);
            this.dockPanel1_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel1_Container.Name = "dockPanel1_Container";
            this.dockPanel1_Container.Size = new System.Drawing.Size(242, 466);
            this.dockPanel1_Container.TabIndex = 0;
            // 
            // ServiceControl
            // 
            this.ServiceControl.DataSource = null;
            this.ServiceControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ServiceControl.Location = new System.Drawing.Point(0, 0);
            this.ServiceControl.Name = "ServiceControl";
            this.ServiceControl.Size = new System.Drawing.Size(242, 466);
            this.ServiceControl.TabIndex = 0;
            this.ServiceControl.SelectedServiceChanged += new Administrator.Controls.ServiceSelectionChangedHandler(this.ServiceControl_SelectedServiceChanged);
            this.ServiceControl.DataSourceChanged += new System.EventHandler(this.ServiceControl_DataSourceChanged);
            this.ServiceControl.ServiceUpdated += new Administrator.Controls.ServiceUpdatedEvintHandler(this.ServiceControl_ServiceUpdated);
            // 
            // NavigationPanel
            // 
            this.NavigationPanel.Controls.Add(this.dockPanel2_Container);
            this.NavigationPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Right;
            this.NavigationPanel.ID = new System.Guid("892ad8b6-522c-4d46-8706-5ea020ef8b0e");
            this.NavigationPanel.Location = new System.Drawing.Point(597, 34);
            this.NavigationPanel.Name = "NavigationPanel";
            this.NavigationPanel.Size = new System.Drawing.Size(195, 494);
            this.NavigationPanel.Text = "Навигатор";
            // 
            // dockPanel2_Container
            // 
            this.dockPanel2_Container.Controls.Add(this.DateNavigator);
            this.dockPanel2_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel2_Container.Name = "dockPanel2_Container";
            this.dockPanel2_Container.Size = new System.Drawing.Size(189, 466);
            this.dockPanel2_Container.TabIndex = 0;
            // 
            // DateNavigator
            // 
            this.DateNavigator.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DateNavigator.Location = new System.Drawing.Point(0, 0);
            this.DateNavigator.Name = "DateNavigator";
            this.DateNavigator.SchedulerControl = this.Scheduler;
            this.DateNavigator.Size = new System.Drawing.Size(189, 466);
            this.DateNavigator.TabIndex = 0;
            // 
            // Scheduler
            // 
            this.Scheduler.Dock = System.Windows.Forms.DockStyle.Fill;
            this.Scheduler.Location = new System.Drawing.Point(248, 34);
            this.Scheduler.MenuManager = this.BarManager;
            this.Scheduler.Name = "Scheduler";
            this.Scheduler.OptionsCustomization.AllowAppointmentConflicts = DevExpress.XtraScheduler.AppointmentConflictsMode.Forbidden;
            this.Scheduler.OptionsCustomization.AllowInplaceEditor = DevExpress.XtraScheduler.UsedAppointmentType.None;
            this.Scheduler.ResourceNavigator.Visibility = DevExpress.XtraScheduler.ResourceNavigatorVisibility.Never;
            this.Scheduler.Size = new System.Drawing.Size(349, 208);
            this.Scheduler.Start = new System.DateTime(2009, 3, 24, 0, 0, 0, 0);
            this.Scheduler.Storage = this.schedulerStorage;
            this.Scheduler.TabIndex = 7;
            this.Scheduler.Views.DayView.TimeRulers.Add(timeRuler3);
            this.Scheduler.Views.WorkWeekView.TimeRulers.Add(timeRuler4);
            this.Scheduler.PreparePopupMenu += new DevExpress.XtraScheduler.PreparePopupMenuEventHandler(this.Scheduler_PreparePopupMenu);
            this.Scheduler.EditAppointmentFormShowing += new DevExpress.XtraScheduler.AppointmentFormEventHandler(this.Scheduler_EditAppointmentFormShowing);
            this.Scheduler.CustomDrawAppointmentBackground += new DevExpress.XtraScheduler.CustomDrawObjectEventHandler(this.Scheduler_CustomDrawAppointmentBackground);
            // 
            // schedulerStorage
            // 
            this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("service_event_id", "service_event_id"));
            this.schedulerStorage.Appointments.CustomFieldMappings.Add(new DevExpress.XtraScheduler.AppointmentCustomFieldMapping("event_id", "event_id"));
            this.schedulerStorage.Appointments.Filter = "[event_id] = \'6d31a342-9723-4b06-9680-5faa2de6f231\'";
            this.schedulerStorage.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.SystemColors.Window, "None", "&None"));
            this.schedulerStorage.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(255)))), ((int)(((byte)(194)))), ((int)(((byte)(190))))), "Important", "&Important"));
            this.schedulerStorage.Appointments.Labels.Add(new DevExpress.XtraScheduler.AppointmentLabel(System.Drawing.Color.FromArgb(((int)(((byte)(207)))), ((int)(((byte)(219)))), ((int)(((byte)(152))))), "Needs Preparation", "&Needs Preparation"));
            this.schedulerStorage.Appointments.Mappings.Description = "description";
            this.schedulerStorage.Appointments.Mappings.End = "end_date";
            this.schedulerStorage.Appointments.Mappings.ResourceId = "service_id";
            this.schedulerStorage.Appointments.Mappings.Start = "start_date";
            this.schedulerStorage.Appointments.Mappings.Subject = "name";
            this.schedulerStorage.AppointmentsChanged += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage_AppointmentsChanged);
            this.schedulerStorage.AppointmentsInserted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage_AppointmentsInserted);
            this.schedulerStorage.AppointmentsDeleted += new DevExpress.XtraScheduler.PersistentObjectsEventHandler(this.schedulerStorage_AppointmentsDeleted);
            this.schedulerStorage.AppointmentChanging += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage_AppointmentChanging);
            this.schedulerStorage.AppointmentDeleting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage_AppointmentDeleting);
            this.schedulerStorage.AppointmentInserting += new DevExpress.XtraScheduler.PersistentObjectCancelEventHandler(this.schedulerStorage_AppointmentInserting);
            // 
            // EventPanel
            // 
            this.EventPanel.Controls.Add(this.dockPanel3_Container);
            this.EventPanel.Dock = DevExpress.XtraBars.Docking.DockingStyle.Bottom;
            this.EventPanel.ID = new System.Guid("c9543589-9b0f-4254-97bb-fd1d81552c7c");
            this.EventPanel.Location = new System.Drawing.Point(248, 242);
            this.EventPanel.Name = "EventPanel";
            this.EventPanel.Size = new System.Drawing.Size(349, 286);
            this.EventPanel.Text = "Мероприятия";
            // 
            // dockPanel3_Container
            // 
            this.dockPanel3_Container.Controls.Add(this.EventList);
            this.dockPanel3_Container.Location = new System.Drawing.Point(3, 25);
            this.dockPanel3_Container.Name = "dockPanel3_Container";
            this.dockPanel3_Container.Size = new System.Drawing.Size(343, 258);
            this.dockPanel3_Container.TabIndex = 0;
            // 
            // EventList
            // 
            this.EventList.DataSource = null;
            this.EventList.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventList.Location = new System.Drawing.Point(0, 0);
            this.EventList.Name = "EventList";
            this.EventList.Size = new System.Drawing.Size(343, 258);
            this.EventList.TabIndex = 0;
            this.EventList.CurrentEventChanged += new Administrator.Controls.CurrentEventChangedEventHandler(this.EventList_CurrentEventChanged);
            this.EventList.AllOrganizationsSourceNeeded += new Administrator.EventArgsReferences.DataSourceNeededEventHandler(this.EventList_AllOrganizationsTableNeeded);
            this.EventList.AllPersonsTableNeeded += new Administrator.EventArgsReferences.DataSourceNeededEventHandler(this.EventList_AllPersonsTableNeeded);
            this.EventList.EventClosed += new Administrator.Controls.EventCloseEventHandler(this.EventList_EventClosed);
            this.EventList.EventUpdated += new Administrator.Controls.EventUpdatedEventHandler(this.EventList_EventUpdated);
            // 
            // MenuNewEvent
            // 
            this.MenuNewEvent.Caption = "Новое событие";
            this.MenuNewEvent.Id = 5;
            this.MenuNewEvent.Name = "MenuNewEvent";
            // 
            // SchedulerControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.Scheduler);
            this.Controls.Add(this.EventPanel);
            this.Controls.Add(this.NavigationPanel);
            this.Controls.Add(this.ServicePanel);
            this.Controls.Add(this.barDockControlLeft);
            this.Controls.Add(this.barDockControlRight);
            this.Controls.Add(this.barDockControlBottom);
            this.Controls.Add(this.barDockControlTop);
            this.Name = "SchedulerControl";
            this.Size = new System.Drawing.Size(792, 528);
            ((System.ComponentModel.ISupportInitialize)(this.BarManager)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DockManager)).EndInit();
            this.ServicePanel.ResumeLayout(false);
            this.dockPanel1_Container.ResumeLayout(false);
            this.NavigationPanel.ResumeLayout(false);
            this.dockPanel2_Container.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DateNavigator)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.Scheduler)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage)).EndInit();
            this.EventPanel.ResumeLayout(false);
            this.dockPanel3_Container.ResumeLayout(false);
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraBars.Bar bar2;
        private DevExpress.XtraBars.BarManager BarManager;
        private DevExpress.XtraBars.Bar bar1;
        private DevExpress.XtraBars.BarDockControl barDockControlTop;
        private DevExpress.XtraBars.BarDockControl barDockControlBottom;
        private DevExpress.XtraBars.BarDockControl barDockControlLeft;
        private DevExpress.XtraBars.BarDockControl barDockControlRight;
        private DevExpress.XtraBars.Docking.DockManager DockManager;
        private DevExpress.XtraBars.Docking.DockPanel EventPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel3_Container;
        private DevExpress.XtraBars.Docking.DockPanel NavigationPanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel2_Container;
        private DevExpress.XtraBars.Docking.DockPanel ServicePanel;
        private DevExpress.XtraBars.Docking.ControlContainer dockPanel1_Container;
        private ServiceControl ServiceControl;
        private EventListControl EventList;
        private DevExpress.XtraScheduler.SchedulerControl Scheduler;
        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage;
        private DevExpress.XtraScheduler.DateNavigator DateNavigator;
        private DevExpress.XtraBars.BarSubItem MenuView;
        private DevExpress.XtraBars.BarSubItem MenuPanels;
        private DevExpress.XtraBars.BarCheckItem MenuServices;
        private DevExpress.XtraBars.BarCheckItem MenuEvents;
        private DevExpress.XtraBars.BarCheckItem MenuDataNavigator;
        private DevExpress.XtraBars.BarSubItem MenuNewEvent;
        private DevExpress.XtraBars.BarButtonItem FilterByEvent;

    }
}

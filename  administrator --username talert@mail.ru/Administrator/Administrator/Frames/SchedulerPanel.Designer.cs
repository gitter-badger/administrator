using Administrator.Controls;

namespace Administrator.Frames
{
    partial class SchedulerPanel
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

        #region Windows Form Designer generated code

        /// <summary>
        /// Required method for Designer support - do not modify
        /// the contents of this method with the code editor.
        /// </summary>
        private void InitializeComponent()
        {
            this.components = new System.ComponentModel.Container();
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(SchedulerPanel));
            this.schedulerStorage1 = new DevExpress.XtraScheduler.SchedulerStorage(this.components);
            this.ShedulerControl = new Administrator.Controls.SchedulerControl();
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).BeginInit();
            this.SuspendLayout();
            // 
            // ShedulerControl
            // 
            this.ShedulerControl.AppintmentsDataSource = null;
            this.ShedulerControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ShedulerControl.EventDataSource = null;
            this.ShedulerControl.Location = new System.Drawing.Point(0, 0);
            this.ShedulerControl.Name = "ShedulerControl";
            this.ShedulerControl.ServicesDataSource = null;
            this.ShedulerControl.Size = new System.Drawing.Size(822, 595);
            this.ShedulerControl.TabIndex = 0;
            this.ShedulerControl.AppintmentDelated += new Administrator.Controls.AppointmentChangedEventHandler(this.ShedulerControl_AppintmentDelated);
            this.ShedulerControl.EventUpdated += new Administrator.Controls.EventUpdatedEventHandler(this.ShedulerControl_EventUpdated);
            this.ShedulerControl.ServiceIdsNeededForEvent += new Administrator.Controls.ServiceIdsForEventsNeededEventHandler(this.ShedulerControl_ServiceIdsNeededForEvent);
            this.ShedulerControl.AllPersonsSouurceNeeded += new Administrator.EventArgsReferences.DataSourceNeededEventHandler(this.ShedulerControl_AllPersonsSourceNeeded);
            this.ShedulerControl.AllOrganizationsSourceNeeded += new Administrator.EventArgsReferences.DataSourceNeededEventHandler(this.ShedulerControl_AllOrganizationsSourceNeeded);
            this.ShedulerControl.EventClosed += new Administrator.Controls.EventCloseEventHandler(this.ShedulerControl_EventClosed);
            this.ShedulerControl.AppintmentModified += new Administrator.Controls.AppointmentChangedEventHandler(this.ShedulerControl_AppintmentModified);
            this.ShedulerControl.ServiceUpdated += new Administrator.Controls.ServiceUpdatedEvintHandler(this.ShedulerControl_ServiceUpdated);
            this.ShedulerControl.AppintmentAdded += new Administrator.Controls.AppointmentChangedEventHandler(this.ShedulerControl_AppintmentAdded);
            // 
            // SchedulerPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(822, 595);
            this.Controls.Add(this.ShedulerControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "SchedulerPanel";
            this.Text = "Мероприятия";
            this.Shown += new System.EventHandler(this.ShedulerPanel_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.schedulerStorage1)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraScheduler.SchedulerStorage schedulerStorage1;
        private Administrator.Controls.SchedulerControl ShedulerControl;
    }
}
namespace Administrator.Frames
{
    partial class MainPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(MainPanel));
            this.organizationButton = new DevExpress.XtraEditors.SimpleButton();
            this.personButton = new DevExpress.XtraEditors.SimpleButton();
            this.eventsButton = new DevExpress.XtraEditors.SimpleButton();
            this.reportButton = new DevExpress.XtraEditors.SimpleButton();
            this.SuspendLayout();
            // 
            // organizationButton
            // 
            this.organizationButton.Image = global::Administrator.Properties.Resources.office_building;
            this.organizationButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.organizationButton.Location = new System.Drawing.Point(13, 13);
            this.organizationButton.Name = "organizationButton";
            this.organizationButton.Size = new System.Drawing.Size(100, 100);
            this.organizationButton.TabIndex = 0;
            this.organizationButton.Text = "Организации";
            this.organizationButton.Click += new System.EventHandler(this.organizationButton_Click);
            // 
            // personButton
            // 
            this.personButton.Image = global::Administrator.Properties.Resources.group;
            this.personButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.personButton.Location = new System.Drawing.Point(119, 13);
            this.personButton.Name = "personButton";
            this.personButton.Size = new System.Drawing.Size(100, 100);
            this.personButton.TabIndex = 1;
            this.personButton.Text = "Сотрудники";
            this.personButton.Click += new System.EventHandler(this.personButton_Click);
            // 
            // eventsButton
            // 
            this.eventsButton.Image = global::Administrator.Properties.Resources.index;
            this.eventsButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.eventsButton.Location = new System.Drawing.Point(225, 13);
            this.eventsButton.Name = "eventsButton";
            this.eventsButton.Size = new System.Drawing.Size(100, 100);
            this.eventsButton.TabIndex = 2;
            this.eventsButton.Text = "Мероприятия";
            this.eventsButton.Click += new System.EventHandler(this.eventsButton_Click);
            // 
            // reportButton
            // 
            this.reportButton.Image = global::Administrator.Properties.Resources.folder_blue_64_64;
            this.reportButton.ImageLocation = DevExpress.XtraEditors.ImageLocation.TopCenter;
            this.reportButton.Location = new System.Drawing.Point(408, 13);
            this.reportButton.Name = "reportButton";
            this.reportButton.Size = new System.Drawing.Size(100, 100);
            this.reportButton.TabIndex = 3;
            this.reportButton.Text = "Отчёты";
            this.reportButton.Click += new System.EventHandler(this.reportButton_Click);
            // 
            // MainPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 415);
            this.ControlBox = false;
            this.Controls.Add(this.reportButton);
            this.Controls.Add(this.eventsButton);
            this.Controls.Add(this.personButton);
            this.Controls.Add(this.organizationButton);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "MainPanel";
            this.Text = "Главная";
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton organizationButton;
        private DevExpress.XtraEditors.SimpleButton personButton;
        private DevExpress.XtraEditors.SimpleButton eventsButton;
        private DevExpress.XtraEditors.SimpleButton reportButton;
    }
}
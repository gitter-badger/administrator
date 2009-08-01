namespace Administrator.Frames
{
    partial class OrganizationPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(OrganizationPanel));
            this.organizationListControl = new Administrator.Controls.OrganizationListControl();
            this.SuspendLayout();
            // 
            // organizationListControl
            // 
            this.organizationListControl.DataSource = null;
            this.organizationListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.organizationListControl.Location = new System.Drawing.Point(0, 0);
            this.organizationListControl.Name = "organizationListControl";
            this.organizationListControl.Size = new System.Drawing.Size(683, 415);
            this.organizationListControl.TabIndex = 0;
            this.organizationListControl.OrganizationUpdated += new Administrator.Controls.OrganizationUpdatedDelegete(this.organizationListControl_OrganizationAdded);
            this.organizationListControl.MovedFromBlackList += new Administrator.EventArgsReferences.MovedFromBlackListEventHandler(this.organizationListControl_MovedFromBlackList);
            this.organizationListControl.MovedToBlackList += new Administrator.EventArgsReferences.MovedToBlackListEventHandler(this.organizationListControl_MovedToBlackList);
            // 
            // OrganizationPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 415);
            this.Controls.Add(this.organizationListControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "OrganizationPanel";
            this.Text = "Организации";
            this.Shown += new System.EventHandler(this.OrganizationPanel_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Administrator.Controls.OrganizationListControl organizationListControl;
    }
}
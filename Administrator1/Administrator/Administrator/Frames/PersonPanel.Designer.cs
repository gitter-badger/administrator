using Administrator.Controls;

namespace Administrator.Frames
{
    partial class PersonPanel
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
            System.ComponentModel.ComponentResourceManager resources = new System.ComponentModel.ComponentResourceManager(typeof(PersonPanel));
            this.personListControl = new Administrator.Controls.PersonListControl();
            this.SuspendLayout();
            // 
            // personListControl
            // 
            this.personListControl.Dock = System.Windows.Forms.DockStyle.Fill;
            this.personListControl.Location = new System.Drawing.Point(0, 0);
            this.personListControl.Name = "personListControl";
            this.personListControl.Size = new System.Drawing.Size(683, 415);
            this.personListControl.TabIndex = 0;
            this.personListControl.PersonUpdated += new PersonUpdatedDelegete(this.personListControl_PersonUpdateed);
            // 
            // PersonPanel
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(683, 415);
            this.Controls.Add(this.personListControl);
            this.Icon = ((System.Drawing.Icon)(resources.GetObject("$this.Icon")));
            this.Name = "PersonPanel";
            this.Text = "Сотрудники";
            this.Shown += new System.EventHandler(this.PersonPanel_Shown);
            this.ResumeLayout(false);

        }

        #endregion

        private Administrator.Controls.PersonListControl personListControl;
    }
}
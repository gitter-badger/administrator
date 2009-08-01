namespace Administrator.Controls
{
    partial class PersonSelectorControl
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
            this.LookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // LookUpEdit
            // 
            this.LookUpEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.LookUpEdit.Location = new System.Drawing.Point(0, 0);
            this.LookUpEdit.Name = "LookUpEdit";
            this.LookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo),
            new DevExpress.XtraEditors.Controls.EditorButton("add", DevExpress.XtraEditors.Controls.ButtonPredefines.Plus)});
            this.LookUpEdit.Size = new System.Drawing.Size(324, 20);
            this.LookUpEdit.TabIndex = 0;
            this.LookUpEdit.ButtonClick += new DevExpress.XtraEditors.Controls.ButtonPressedEventHandler(this.LookUpEdit_ButtonClick);
            // 
            // PersonSelectorControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.LookUpEdit);
            this.Name = "PersonSelectorControl";
            this.Size = new System.Drawing.Size(324, 23);
            ((System.ComponentModel.ISupportInitialize)(this.LookUpEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LookUpEdit LookUpEdit;
    }
}

namespace Administrator.Frames
{
    partial class CustomAppointmentForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.EndTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.EndDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.StartTimeEdit = new DevExpress.XtraEditors.TimeEdit();
            this.StartDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.DescriptionEdit = new DevExpress.XtraEditors.MemoEdit();
            this.CuncelButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkButton = new DevExpress.XtraEditors.SimpleButton();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.EndTimeEdit);
            this.groupControl1.Controls.Add(this.EndDateEdit);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.StartTimeEdit);
            this.groupControl1.Controls.Add(this.StartDateEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(324, 76);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Главные";
            // 
            // EndTimeEdit
            // 
            this.EndTimeEdit.EditValue = new System.DateTime(2009, 4, 3, 0, 0, 0, 0);
            this.EndTimeEdit.Location = new System.Drawing.Point(212, 49);
            this.EndTimeEdit.Name = "EndTimeEdit";
            this.EndTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EndTimeEdit.Size = new System.Drawing.Size(100, 20);
            this.EndTimeEdit.TabIndex = 3;
            // 
            // EndDateEdit
            // 
            this.EndDateEdit.EditValue = null;
            this.EndDateEdit.Location = new System.Drawing.Point(106, 49);
            this.EndDateEdit.Name = "EndDateEdit";
            this.EndDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EndDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EndDateEdit.Size = new System.Drawing.Size(100, 20);
            this.EndDateEdit.TabIndex = 2;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(60, 13);
            this.labelControl4.TabIndex = 4;
            this.labelControl4.Text = "Окончание:";
            // 
            // StartTimeEdit
            // 
            this.StartTimeEdit.EditValue = new System.DateTime(2009, 4, 3, 0, 0, 0, 0);
            this.StartTimeEdit.Location = new System.Drawing.Point(212, 23);
            this.StartTimeEdit.Name = "StartTimeEdit";
            this.StartTimeEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.StartTimeEdit.Size = new System.Drawing.Size(100, 20);
            this.StartTimeEdit.TabIndex = 1;
            // 
            // StartDateEdit
            // 
            this.StartDateEdit.EditValue = null;
            this.StartDateEdit.Location = new System.Drawing.Point(106, 23);
            this.StartDateEdit.Name = "StartDateEdit";
            this.StartDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.StartDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.StartDateEdit.Size = new System.Drawing.Size(100, 20);
            this.StartDateEdit.TabIndex = 0;
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(41, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Начало:";
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.DescriptionEdit);
            this.groupControl2.Location = new System.Drawing.Point(12, 95);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(327, 137);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Заметки";
            // 
            // DescriptionEdit
            // 
            this.DescriptionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.DescriptionEdit.Location = new System.Drawing.Point(2, 20);
            this.DescriptionEdit.Name = "DescriptionEdit";
            this.DescriptionEdit.Size = new System.Drawing.Size(323, 115);
            this.DescriptionEdit.TabIndex = 0;
            // 
            // CuncelButton
            // 
            this.CuncelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CuncelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CuncelButton.Image = global::Administrator.Properties.Resources.delete_16_16;
            this.CuncelButton.Location = new System.Drawing.Point(264, 238);
            this.CuncelButton.Name = "CuncelButton";
            this.CuncelButton.Size = new System.Drawing.Size(75, 23);
            this.CuncelButton.TabIndex = 3;
            this.CuncelButton.Text = "Отмена";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Image = global::Administrator.Properties.Resources.check_16_16;
            this.OkButton.Location = new System.Drawing.Point(173, 238);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 23);
            this.OkButton.TabIndex = 2;
            this.OkButton.Text = "Сохранить";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CustomAppointmentForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(352, 273);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CuncelButton);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "CustomAppointmentForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Событие";
            this.Shown += new System.EventHandler(this.CustomAppointmentForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EndTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EndDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartTimeEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.StartDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.DescriptionEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.MemoEdit DescriptionEdit;
        private DevExpress.XtraEditors.SimpleButton CuncelButton;
        private DevExpress.XtraEditors.SimpleButton OkButton;
        private DevExpress.XtraEditors.TimeEdit EndTimeEdit;
        private DevExpress.XtraEditors.DateEdit EndDateEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TimeEdit StartTimeEdit;
        private DevExpress.XtraEditors.DateEdit StartDateEdit;

    }
}
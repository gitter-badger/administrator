namespace Administrator.Frames
{
    partial class ServiceDetailsForm
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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.ServiceNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.ServiceTypeComboEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.OkButton = new DevExpress.XtraEditors.SimpleButton();
            this.CustomErrorProvider = new Administrator.Controls.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeComboEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.ServiceNameEdit);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.ServiceTypeComboEdit);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(6, 12);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(428, 78);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Главные";
            // 
            // ServiceNameEdit
            // 
            this.ServiceNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomErrorProvider.SetIconAlignment(this.ServiceNameEdit, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.CustomErrorProvider.SetIconPadding(this.ServiceNameEdit, 3);
            this.ServiceNameEdit.Location = new System.Drawing.Point(94, 50);
            this.ServiceNameEdit.Name = "ServiceNameEdit";
            this.CustomErrorProvider.SetRequired(this.ServiceNameEdit, false);
            this.ServiceNameEdit.Size = new System.Drawing.Size(329, 20);
            this.ServiceNameEdit.TabIndex = 1;
            this.ServiceNameEdit.Validating += new System.ComponentModel.CancelEventHandler(this.ServiceNameEdit_Validating);
            // 
            // labelControl2
            // 
            this.labelControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl2.Location = new System.Drawing.Point(7, 53);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(52, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Название:";
            // 
            // ServiceTypeComboEdit
            // 
            this.ServiceTypeComboEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.CustomErrorProvider.SetIconAlignment(this.ServiceTypeComboEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.CustomErrorProvider.SetIconPadding(this.ServiceTypeComboEdit, 3);
            this.ServiceTypeComboEdit.Location = new System.Drawing.Point(94, 24);
            this.ServiceTypeComboEdit.Name = "ServiceTypeComboEdit";
            this.ServiceTypeComboEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.CustomErrorProvider.SetRequired(this.ServiceTypeComboEdit, false);
            this.ServiceTypeComboEdit.Size = new System.Drawing.Size(329, 20);
            this.ServiceTypeComboEdit.TabIndex = 0;
            this.ServiceTypeComboEdit.Validating += new System.ComponentModel.CancelEventHandler(this.ServiceTypeComboEdit_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.labelControl1.Location = new System.Drawing.Point(7, 27);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(59, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Тип услуги:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Image = global::Administrator.Properties.Resources.delete_16_16;
            this.CancelButton.Location = new System.Drawing.Point(6, 96);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 2;
            this.CancelButton.Text = "Отмена";
            // 
            // OkButton
            // 
            this.OkButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.OkButton.Image = global::Administrator.Properties.Resources.check_16_16;
            this.OkButton.Location = new System.Drawing.Point(349, 96);
            this.OkButton.Name = "OkButton";
            this.OkButton.Size = new System.Drawing.Size(85, 23);
            this.OkButton.TabIndex = 1;
            this.OkButton.Text = "Сохранить";
            this.OkButton.Click += new System.EventHandler(this.OkButton_Click);
            // 
            // CustomErrorProvider
            // 
            this.CustomErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.CustomErrorProvider.ContainerControl = this;
            this.CustomErrorProvider.IgnoreOnCancel = true;
            // 
            // ServiceDetailsForm
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(443, 125);
            this.Controls.Add(this.OkButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "ServiceDetailsForm";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Услуга";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ServiceTypeComboEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.CustomErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.ComboBoxEdit ServiceTypeComboEdit;
        private DevExpress.XtraEditors.TextEdit ServiceNameEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton OkButton;
        private Administrator.Controls.CustomErrorProvider CustomErrorProvider;
    }
}
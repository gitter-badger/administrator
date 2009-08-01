namespace Administrator.Controls
{
    partial class OrganizationDetailsControl
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
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.descriptionEdit = new DevExpress.XtraEditors.MemoEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.phoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.emailEdit = new DevExpress.XtraEditors.TextEdit();
            this.addressEdit = new DevExpress.XtraEditors.TextEdit();
            this.postAddressEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.legalAddresEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.directorNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.scopeOfActivityEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.discauntSpinEdit = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.fullNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.shortNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.ErrorProvider = new Administrator.Controls.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAddressEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.legalAddresEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeOfActivityEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.discauntSpinEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.descriptionEdit);
            this.groupControl3.Location = new System.Drawing.Point(3, 328);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(414, 222);
            this.groupControl3.TabIndex = 2;
            this.groupControl3.Text = "Заметки";
            // 
            // descriptionEdit
            // 
            this.descriptionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionEdit.Location = new System.Drawing.Point(2, 20);
            this.descriptionEdit.Name = "descriptionEdit";
            this.ErrorProvider.SetRequired(this.descriptionEdit, false);
            this.descriptionEdit.Size = new System.Drawing.Size(410, 200);
            this.descriptionEdit.TabIndex = 0;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.phoneEdit);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.emailEdit);
            this.groupControl2.Controls.Add(this.addressEdit);
            this.groupControl2.Controls.Add(this.postAddressEdit);
            this.groupControl2.Controls.Add(this.labelControl9);
            this.groupControl2.Controls.Add(this.labelControl5);
            this.groupControl2.Controls.Add(this.legalAddresEdit);
            this.groupControl2.Controls.Add(this.labelControl2);
            this.groupControl2.Location = new System.Drawing.Point(3, 161);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(414, 161);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Конатактные данные";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(5, 109);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(48, 13);
            this.labelControl4.TabIndex = 31;
            this.labelControl4.Text = "Телефон:";
            // 
            // phoneEdit
            // 
            this.phoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneEdit.Location = new System.Drawing.Point(142, 106);
            this.phoneEdit.Name = "phoneEdit";
            this.ErrorProvider.SetRequired(this.phoneEdit, false);
            this.phoneEdit.Size = new System.Drawing.Size(267, 20);
            this.phoneEdit.TabIndex = 3;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 135);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 29;
            this.labelControl7.Text = "e-mail:";
            // 
            // emailEdit
            // 
            this.emailEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailEdit.Location = new System.Drawing.Point(142, 132);
            this.emailEdit.Name = "emailEdit";
            this.ErrorProvider.SetRequired(this.emailEdit, false);
            this.emailEdit.Size = new System.Drawing.Size(267, 20);
            this.emailEdit.TabIndex = 4;
            // 
            // addressEdit
            // 
            this.addressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.addressEdit.Location = new System.Drawing.Point(142, 80);
            this.addressEdit.Name = "addressEdit";
            this.ErrorProvider.SetRequired(this.addressEdit, false);
            this.addressEdit.Size = new System.Drawing.Size(267, 20);
            this.addressEdit.TabIndex = 2;
            // 
            // postAddressEdit
            // 
            this.postAddressEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.postAddressEdit.Location = new System.Drawing.Point(142, 54);
            this.postAddressEdit.Name = "postAddressEdit";
            this.ErrorProvider.SetRequired(this.postAddressEdit, false);
            this.postAddressEdit.Size = new System.Drawing.Size(267, 20);
            this.postAddressEdit.TabIndex = 1;
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(4, 83);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(104, 13);
            this.labelControl9.TabIndex = 26;
            this.labelControl9.Text = "Фактический адрес:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 31);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(107, 13);
            this.labelControl5.TabIndex = 23;
            this.labelControl5.Text = "Юридический адрес:";
            // 
            // legalAddresEdit
            // 
            this.legalAddresEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.legalAddresEdit.Location = new System.Drawing.Point(142, 28);
            this.legalAddresEdit.Name = "legalAddresEdit";
            this.ErrorProvider.SetRequired(this.legalAddresEdit, false);
            this.legalAddresEdit.Size = new System.Drawing.Size(267, 20);
            this.legalAddresEdit.TabIndex = 0;
            this.legalAddresEdit.EditValueChanged += new System.EventHandler(this.legalAddresEdit_EditValueChanged);
            this.legalAddresEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.legalAddresEdit_EditValueChanging);
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(4, 57);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(88, 13);
            this.labelControl2.TabIndex = 25;
            this.labelControl2.Text = "Почтовый адрес:";
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.directorNameEdit);
            this.groupControl1.Controls.Add(this.labelControl10);
            this.groupControl1.Controls.Add(this.scopeOfActivityEdit);
            this.groupControl1.Controls.Add(this.discauntSpinEdit);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.fullNameEdit);
            this.groupControl1.Controls.Add(this.shortNameEdit);
            this.groupControl1.Location = new System.Drawing.Point(3, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(414, 152);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Основные данные";
            // 
            // directorNameEdit
            // 
            this.directorNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.directorNameEdit.Location = new System.Drawing.Point(142, 75);
            this.directorNameEdit.Name = "directorNameEdit";
            this.directorNameEdit.Properties.ReadOnly = true;
            this.ErrorProvider.SetRequired(this.directorNameEdit, false);
            this.directorNameEdit.Size = new System.Drawing.Size(267, 20);
            this.directorNameEdit.TabIndex = 2;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(4, 78);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(124, 13);
            this.labelControl10.TabIndex = 13;
            this.labelControl10.Text = "Генеральный директор:";
            // 
            // scopeOfActivityEdit
            // 
            this.scopeOfActivityEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.scopeOfActivityEdit.Location = new System.Drawing.Point(142, 101);
            this.scopeOfActivityEdit.Name = "scopeOfActivityEdit";
            this.scopeOfActivityEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ErrorProvider.SetRequired(this.scopeOfActivityEdit, false);
            this.scopeOfActivityEdit.Size = new System.Drawing.Size(267, 20);
            this.scopeOfActivityEdit.TabIndex = 3;
            // 
            // discauntSpinEdit
            // 
            this.discauntSpinEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.discauntSpinEdit.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.discauntSpinEdit.Location = new System.Drawing.Point(142, 127);
            this.discauntSpinEdit.Name = "discauntSpinEdit";
            this.discauntSpinEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.discauntSpinEdit.Properties.Mask.EditMask = "(0|[1-9]|[1-9][0-9]|100)";
            this.discauntSpinEdit.Properties.Mask.MaskType = DevExpress.XtraEditors.Mask.MaskType.RegEx;
            this.ErrorProvider.SetRequired(this.discauntSpinEdit, false);
            this.discauntSpinEdit.Size = new System.Drawing.Size(267, 20);
            this.discauntSpinEdit.TabIndex = 4;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(5, 130);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(61, 13);
            this.labelControl8.TabIndex = 10;
            this.labelControl8.Text = "Скидка(%):";
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 104);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(112, 13);
            this.labelControl3.TabIndex = 8;
            this.labelControl3.Text = "Сфера деятельности:";
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Название:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(4, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(103, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Короткое название:";
            // 
            // fullNameEdit
            // 
            this.fullNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProvider.SetIconAlignment(this.fullNameEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.fullNameEdit, 3);
            this.fullNameEdit.Location = new System.Drawing.Point(142, 23);
            this.fullNameEdit.Name = "fullNameEdit";
            this.ErrorProvider.SetRequired(this.fullNameEdit, false);
            this.fullNameEdit.Size = new System.Drawing.Size(267, 20);
            this.fullNameEdit.TabIndex = 0;
            // 
            // shortNameEdit
            // 
            this.shortNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProvider.SetIconAlignment(this.shortNameEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.shortNameEdit, 3);
            this.shortNameEdit.Location = new System.Drawing.Point(142, 49);
            this.shortNameEdit.Name = "shortNameEdit";
            this.ErrorProvider.SetRequired(this.shortNameEdit, false);
            this.shortNameEdit.Size = new System.Drawing.Size(267, 20);
            this.shortNameEdit.TabIndex = 1;
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.IgnoreOnCancel = true;
            // 
            // OrganizationDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "OrganizationDetailsControl";
            this.Size = new System.Drawing.Size(421, 553);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.OrganizationDetailsControl_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.addressEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.postAddressEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.legalAddresEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.directorNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.scopeOfActivityEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.discauntSpinEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.fullNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.shortNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit descriptionEdit;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit fullNameEdit;
        private DevExpress.XtraEditors.TextEdit shortNameEdit;
        private DevExpress.XtraEditors.TextEdit addressEdit;
        private DevExpress.XtraEditors.TextEdit postAddressEdit;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.TextEdit legalAddresEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit emailEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit phoneEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.SpinEdit discauntSpinEdit;
        private CustomErrorProvider ErrorProvider;
        private DevExpress.XtraEditors.ComboBoxEdit scopeOfActivityEdit;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.TextEdit directorNameEdit;

    }
}

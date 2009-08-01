namespace Administrator.Controls
{
    partial class PersonDetailsControl
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
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.surNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.firstNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.lastNameEdit = new DevExpress.XtraEditors.TextEdit();
            this.phoneEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.mobileEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.emailEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.isqEdit = new DevExpress.XtraEditors.TextEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl9 = new DevExpress.XtraEditors.LabelControl();
            this.sexComboEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.postComboEdit = new DevExpress.XtraEditors.ComboBoxEdit();
            this.groupControl2 = new DevExpress.XtraEditors.GroupControl();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.descriptionEdit = new DevExpress.XtraEditors.MemoEdit();
            this.photoEdit = new DevExpress.XtraEditors.PictureEdit();
            this.groupControl4 = new DevExpress.XtraEditors.GroupControl();
            this.organizationLookUpEdit = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl10 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl11 = new DevExpress.XtraEditors.LabelControl();
            this.ErrorProvider = new Administrator.Controls.CustomErrorProvider(this.components);
            ((System.ComponentModel.ISupportInitialize)(this.surNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.isqEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexComboEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postComboEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).BeginInit();
            this.groupControl2.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).BeginInit();
            this.groupControl4.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationLookUpEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            this.SuspendLayout();
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(4, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(48, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Фамилия:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(4, 78);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(53, 13);
            this.labelControl5.TabIndex = 4;
            this.labelControl5.Text = "Отчество:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(4, 52);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(23, 13);
            this.labelControl6.TabIndex = 5;
            this.labelControl6.Text = "Имя:";
            // 
            // surNameEdit
            // 
            this.surNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProvider.SetIconAlignment(this.surNameEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.surNameEdit, 3);
            this.surNameEdit.Location = new System.Drawing.Point(89, 23);
            this.surNameEdit.Name = "surNameEdit";
            this.ErrorProvider.SetRequired(this.surNameEdit, false);
            this.surNameEdit.Size = new System.Drawing.Size(242, 20);
            this.surNameEdit.TabIndex = 0;
            this.surNameEdit.EditValueChanged += new System.EventHandler(this.surNameEdit_EditValueChanged);
            // 
            // firstNameEdit
            // 
            this.firstNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProvider.SetIconAlignment(this.firstNameEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.firstNameEdit, 3);
            this.firstNameEdit.Location = new System.Drawing.Point(89, 49);
            this.firstNameEdit.Name = "firstNameEdit";
            this.ErrorProvider.SetRequired(this.firstNameEdit, false);
            this.firstNameEdit.Size = new System.Drawing.Size(242, 20);
            this.firstNameEdit.TabIndex = 1;
            this.firstNameEdit.EditValueChanged += new System.EventHandler(this.surNameEdit_EditValueChanged);
            // 
            // lastNameEdit
            // 
            this.lastNameEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProvider.SetIconAlignment(this.lastNameEdit, System.Windows.Forms.ErrorIconAlignment.BottomLeft);
            this.ErrorProvider.SetIconPadding(this.lastNameEdit, 3);
            this.lastNameEdit.Location = new System.Drawing.Point(89, 75);
            this.lastNameEdit.Name = "lastNameEdit";
            this.ErrorProvider.SetRequired(this.lastNameEdit, false);
            this.lastNameEdit.Size = new System.Drawing.Size(242, 20);
            this.lastNameEdit.TabIndex = 2;
            this.lastNameEdit.EditValueChanged += new System.EventHandler(this.surNameEdit_EditValueChanged);
            // 
            // phoneEdit
            // 
            this.phoneEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.phoneEdit.Location = new System.Drawing.Point(89, 23);
            this.phoneEdit.Name = "phoneEdit";
            this.ErrorProvider.SetRequired(this.phoneEdit, false);
            this.phoneEdit.Size = new System.Drawing.Size(336, 20);
            this.phoneEdit.TabIndex = 0;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(4, 26);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(48, 13);
            this.labelControl3.TabIndex = 11;
            this.labelControl3.Text = "Телефон:";
            // 
            // mobileEdit
            // 
            this.mobileEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.mobileEdit.Location = new System.Drawing.Point(89, 49);
            this.mobileEdit.Name = "mobileEdit";
            this.ErrorProvider.SetRequired(this.mobileEdit, false);
            this.mobileEdit.Size = new System.Drawing.Size(336, 20);
            this.mobileEdit.TabIndex = 1;
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(4, 52);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(49, 13);
            this.labelControl4.TabIndex = 13;
            this.labelControl4.Text = "Сотовый:";
            // 
            // emailEdit
            // 
            this.emailEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.emailEdit.Location = new System.Drawing.Point(89, 75);
            this.emailEdit.Name = "emailEdit";
            this.ErrorProvider.SetRequired(this.emailEdit, false);
            this.emailEdit.Size = new System.Drawing.Size(336, 20);
            this.emailEdit.TabIndex = 2;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(4, 78);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(32, 13);
            this.labelControl7.TabIndex = 15;
            this.labelControl7.Text = "e-mail:";
            // 
            // isqEdit
            // 
            this.isqEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.isqEdit.Location = new System.Drawing.Point(89, 101);
            this.isqEdit.Name = "isqEdit";
            this.ErrorProvider.SetRequired(this.isqEdit, false);
            this.isqEdit.Size = new System.Drawing.Size(336, 20);
            this.isqEdit.TabIndex = 3;
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(4, 104);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(22, 13);
            this.labelControl8.TabIndex = 17;
            this.labelControl8.Text = "ISQ:";
            // 
            // labelControl9
            // 
            this.labelControl9.Location = new System.Drawing.Point(4, 104);
            this.labelControl9.Name = "labelControl9";
            this.labelControl9.Size = new System.Drawing.Size(23, 13);
            this.labelControl9.TabIndex = 19;
            this.labelControl9.Text = "Пол:";
            // 
            // sexComboEdit
            // 
            this.sexComboEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.sexComboEdit.EditValue = "Мужской";
            this.sexComboEdit.Location = new System.Drawing.Point(89, 101);
            this.sexComboEdit.Name = "sexComboEdit";
            this.sexComboEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.sexComboEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.sexComboEdit.Properties.Items.AddRange(new object[] {
            "Мужской",
            "Женский"});
            this.sexComboEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ErrorProvider.SetRequired(this.sexComboEdit, false);
            this.sexComboEdit.Size = new System.Drawing.Size(242, 20);
            this.sexComboEdit.TabIndex = 3;
            this.sexComboEdit.EditValueChanged += new System.EventHandler(this.sexComboEdit_EditValueChanged);
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.sexComboEdit);
            this.groupControl1.Controls.Add(this.labelControl9);
            this.groupControl1.Controls.Add(this.labelControl5);
            this.groupControl1.Controls.Add(this.labelControl6);
            this.groupControl1.Controls.Add(this.surNameEdit);
            this.groupControl1.Controls.Add(this.firstNameEdit);
            this.groupControl1.Controls.Add(this.lastNameEdit);
            this.groupControl1.Location = new System.Drawing.Point(98, 3);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(336, 130);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Основные данные";
            // 
            // postComboEdit
            // 
            this.postComboEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.postComboEdit.Location = new System.Drawing.Point(89, 49);
            this.postComboEdit.Name = "postComboEdit";
            this.postComboEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ErrorProvider.SetRequired(this.postComboEdit, false);
            this.postComboEdit.Size = new System.Drawing.Size(336, 20);
            this.postComboEdit.TabIndex = 1;
            // 
            // groupControl2
            // 
            this.groupControl2.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl2.Controls.Add(this.isqEdit);
            this.groupControl2.Controls.Add(this.labelControl3);
            this.groupControl2.Controls.Add(this.phoneEdit);
            this.groupControl2.Controls.Add(this.labelControl4);
            this.groupControl2.Controls.Add(this.mobileEdit);
            this.groupControl2.Controls.Add(this.labelControl8);
            this.groupControl2.Controls.Add(this.labelControl7);
            this.groupControl2.Controls.Add(this.emailEdit);
            this.groupControl2.Location = new System.Drawing.Point(4, 139);
            this.groupControl2.Name = "groupControl2";
            this.groupControl2.Size = new System.Drawing.Size(430, 129);
            this.groupControl2.TabIndex = 1;
            this.groupControl2.Text = "Конатактные данные";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.descriptionEdit);
            this.groupControl3.Location = new System.Drawing.Point(4, 354);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(430, 197);
            this.groupControl3.TabIndex = 3;
            this.groupControl3.TabStop = true;
            this.groupControl3.Text = "Заметки";
            // 
            // descriptionEdit
            // 
            this.descriptionEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.descriptionEdit.Location = new System.Drawing.Point(2, 20);
            this.descriptionEdit.Name = "descriptionEdit";
            this.ErrorProvider.SetRequired(this.descriptionEdit, false);
            this.descriptionEdit.Size = new System.Drawing.Size(426, 175);
            this.descriptionEdit.TabIndex = 0;
            this.descriptionEdit.TabStop = false;
            // 
            // photoEdit
            // 
            this.photoEdit.Location = new System.Drawing.Point(4, 4);
            this.photoEdit.Name = "photoEdit";
            this.photoEdit.Properties.SizeMode = DevExpress.XtraEditors.Controls.PictureSizeMode.Zoom;
            this.ErrorProvider.SetRequired(this.photoEdit, false);
            this.photoEdit.Size = new System.Drawing.Size(88, 129);
            this.photoEdit.TabIndex = 25;
            this.photoEdit.DoubleClick += new System.EventHandler(this.photoEdit_DoubleClick);
            this.photoEdit.EditValueChanging += new DevExpress.XtraEditors.Controls.ChangingEventHandler(this.photoEdit_EditValueChanging);
            // 
            // groupControl4
            // 
            this.groupControl4.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl4.Controls.Add(this.organizationLookUpEdit);
            this.groupControl4.Controls.Add(this.postComboEdit);
            this.groupControl4.Controls.Add(this.labelControl10);
            this.groupControl4.Controls.Add(this.labelControl11);
            this.groupControl4.Location = new System.Drawing.Point(4, 274);
            this.groupControl4.Name = "groupControl4";
            this.groupControl4.Size = new System.Drawing.Size(430, 74);
            this.groupControl4.TabIndex = 2;
            this.groupControl4.TabStop = true;
            this.groupControl4.Text = "Работа";
            // 
            // organizationLookUpEdit
            // 
            this.organizationLookUpEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.organizationLookUpEdit.Location = new System.Drawing.Point(89, 23);
            this.organizationLookUpEdit.Name = "organizationLookUpEdit";
            this.organizationLookUpEdit.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.organizationLookUpEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.organizationLookUpEdit.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrganizationID", "OrganizationId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShortName", "Название", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Полное название")});
            this.organizationLookUpEdit.Properties.DisplayMember = "ShortName";
            this.organizationLookUpEdit.Properties.NullText = "Неизвестно";
            this.organizationLookUpEdit.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.Standard;
            this.organizationLookUpEdit.Properties.ValueMember = "OrganizationID";
            this.ErrorProvider.SetRequired(this.organizationLookUpEdit, false);
            this.organizationLookUpEdit.Size = new System.Drawing.Size(336, 20);
            this.organizationLookUpEdit.TabIndex = 0;
            // 
            // labelControl10
            // 
            this.labelControl10.Location = new System.Drawing.Point(4, 26);
            this.labelControl10.Name = "labelControl10";
            this.labelControl10.Size = new System.Drawing.Size(70, 13);
            this.labelControl10.TabIndex = 19;
            this.labelControl10.Text = "Организация:";
            // 
            // labelControl11
            // 
            this.labelControl11.Location = new System.Drawing.Point(4, 52);
            this.labelControl11.Name = "labelControl11";
            this.labelControl11.Size = new System.Drawing.Size(61, 13);
            this.labelControl11.TabIndex = 20;
            this.labelControl11.Text = "Должность:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.IgnoreOnCancel = true;
            // 
            // PersonDetailsControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.photoEdit);
            this.Controls.Add(this.groupControl4);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.groupControl2);
            this.Controls.Add(this.groupControl1);
            this.Name = "PersonDetailsControl";
            this.Size = new System.Drawing.Size(434, 553);
            this.Validating += new System.ComponentModel.CancelEventHandler(this.PersonDetailsControl_Validating);
            ((System.ComponentModel.ISupportInitialize)(this.surNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.firstNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.lastNameEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.phoneEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.mobileEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.emailEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.isqEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.sexComboEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.postComboEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl2)).EndInit();
            this.groupControl2.ResumeLayout(false);
            this.groupControl2.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.descriptionEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.photoEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl4)).EndInit();
            this.groupControl4.ResumeLayout(false);
            this.groupControl4.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.organizationLookUpEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.TextEdit surNameEdit;
        private DevExpress.XtraEditors.TextEdit firstNameEdit;
        private DevExpress.XtraEditors.TextEdit lastNameEdit;
        private DevExpress.XtraEditors.TextEdit phoneEdit;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.TextEdit mobileEdit;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.TextEdit emailEdit;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.TextEdit isqEdit;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl9;
        private DevExpress.XtraEditors.ComboBoxEdit sexComboEdit;
        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.GroupControl groupControl2;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit descriptionEdit;
        private DevExpress.XtraEditors.ComboBoxEdit postComboEdit;
        private CustomErrorProvider ErrorProvider;
        private DevExpress.XtraEditors.PictureEdit photoEdit;
        private DevExpress.XtraEditors.GroupControl groupControl4;
        private DevExpress.XtraEditors.LabelControl labelControl10;
        private DevExpress.XtraEditors.LabelControl labelControl11;
        private DevExpress.XtraEditors.LookUpEdit organizationLookUpEdit;
    }
}

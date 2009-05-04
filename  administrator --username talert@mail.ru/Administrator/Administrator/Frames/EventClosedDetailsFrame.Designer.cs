namespace Administrator.Frames
{
    partial class EventClosedDetailsFrame
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
            this.ExitDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.labelControl8 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.RegistrationDateEdit = new DevExpress.XtraEditors.DateEdit();
            this.EventPersonNumber = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            this.EventType = new DevExpress.XtraEditors.ComboBoxEdit();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EventName = new DevExpress.XtraEditors.TextEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.SaveButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.EventOrganization = new DevExpress.XtraEditors.LookUpEdit();
            this.EventContactPerson = new DevExpress.XtraEditors.LookUpEdit();
            this.labelControl7 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl6 = new DevExpress.XtraEditors.LabelControl();
            this.labelControl5 = new DevExpress.XtraEditors.LabelControl();
            this.ErrorProvider = new Administrator.Controls.CustomErrorProvider(this.components);
            this.ReviewEdit = new DevExpress.XtraEditors.MemoEdit();
            this.EventDescription = new DevExpress.XtraEditors.MemoEdit();
            this.xtraTabControl1 = new DevExpress.XtraTab.XtraTabControl();
            this.xtraTabPage2 = new DevExpress.XtraTab.XtraTabPage();
            this.xtraTabPage1 = new DevExpress.XtraTab.XtraTabPage();
            this.BalanceControl = new Administrator.Controls.BalanceControl();
            this.EventManager = new DevExpress.XtraEditors.LookUpEdit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDateEdit.Properties.VistaTimeProperties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDateEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventPersonNumber.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventType.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventName.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventOrganization.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventContactPerson.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDescription.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).BeginInit();
            this.xtraTabControl1.SuspendLayout();
            this.xtraTabPage2.SuspendLayout();
            this.xtraTabPage1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventManager.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.ExitDateEdit);
            this.groupControl1.Controls.Add(this.labelControl8);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Controls.Add(this.RegistrationDateEdit);
            this.groupControl1.Controls.Add(this.EventPersonNumber);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.EventType);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.EventName);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(452, 131);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Главные";
            // 
            // ExitDateEdit
            // 
            this.ExitDateEdit.EditValue = null;
            this.ErrorProvider.SetIconAlignment(this.ExitDateEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.ExitDateEdit, 3);
            this.ExitDateEdit.Location = new System.Drawing.Point(334, 24);
            this.ExitDateEdit.Name = "ExitDateEdit";
            this.ExitDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.ExitDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ErrorProvider.SetRequired(this.ExitDateEdit, false);
            this.ExitDateEdit.Size = new System.Drawing.Size(113, 20);
            this.ExitDateEdit.TabIndex = 9;
            this.ExitDateEdit.Validating += new System.ComponentModel.CancelEventHandler(this.ExitDateEdit_Validating);
            // 
            // labelControl8
            // 
            this.labelControl8.Location = new System.Drawing.Point(239, 27);
            this.labelControl8.Name = "labelControl8";
            this.labelControl8.Size = new System.Drawing.Size(71, 13);
            this.labelControl8.TabIndex = 8;
            this.labelControl8.Text = "Дата выезда:";
            // 
            // labelControl4
            // 
            this.labelControl4.Location = new System.Drawing.Point(7, 27);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(68, 13);
            this.labelControl4.TabIndex = 7;
            this.labelControl4.Text = "Дата заезда:";
            // 
            // RegistrationDateEdit
            // 
            this.RegistrationDateEdit.EditValue = null;
            this.ErrorProvider.SetIconAlignment(this.RegistrationDateEdit, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.RegistrationDateEdit, 3);
            this.RegistrationDateEdit.Location = new System.Drawing.Point(122, 24);
            this.RegistrationDateEdit.Name = "RegistrationDateEdit";
            this.RegistrationDateEdit.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.RegistrationDateEdit.Properties.VistaTimeProperties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.ErrorProvider.SetRequired(this.RegistrationDateEdit, false);
            this.RegistrationDateEdit.Size = new System.Drawing.Size(111, 20);
            this.RegistrationDateEdit.TabIndex = 5;
            this.RegistrationDateEdit.Validating += new System.ComponentModel.CancelEventHandler(this.RegistrationDateEdit_Validating);
            // 
            // EventPersonNumber
            // 
            this.EventPersonNumber.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EventPersonNumber.Location = new System.Drawing.Point(122, 103);
            this.EventPersonNumber.Name = "EventPersonNumber";
            this.EventPersonNumber.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EventPersonNumber.Properties.Mask.EditMask = "d";
            this.ErrorProvider.SetRequired(this.EventPersonNumber, false);
            this.EventPersonNumber.Size = new System.Drawing.Size(71, 20);
            this.EventPersonNumber.TabIndex = 2;
            // 
            // labelControl3
            // 
            this.labelControl3.Location = new System.Drawing.Point(5, 106);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(96, 13);
            this.labelControl3.TabIndex = 4;
            this.labelControl3.Text = "Число участников:";
            // 
            // EventType
            // 
            this.EventType.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventType.Location = new System.Drawing.Point(122, 77);
            this.EventType.Name = "EventType";
            this.EventType.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.False;
            this.EventType.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EventType.Properties.TextEditStyle = DevExpress.XtraEditors.Controls.TextEditStyles.DisableTextEditor;
            this.ErrorProvider.SetRequired(this.EventType, false);
            this.EventType.Size = new System.Drawing.Size(325, 20);
            this.EventType.TabIndex = 1;
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(22, 13);
            this.labelControl2.TabIndex = 2;
            this.labelControl2.Text = "Тип:";
            // 
            // EventName
            // 
            this.EventName.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ErrorProvider.SetIconAlignment(this.EventName, System.Windows.Forms.ErrorIconAlignment.MiddleLeft);
            this.ErrorProvider.SetIconPadding(this.EventName, 3);
            this.EventName.Location = new System.Drawing.Point(122, 50);
            this.EventName.Name = "EventName";
            this.ErrorProvider.SetRequired(this.EventName, false);
            this.EventName.Size = new System.Drawing.Size(325, 20);
            this.EventName.TabIndex = 0;
            this.EventName.Validating += new System.ComponentModel.CancelEventHandler(this.EventName_Validating);
            // 
            // labelControl1
            // 
            this.labelControl1.Location = new System.Drawing.Point(5, 53);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(52, 13);
            this.labelControl1.TabIndex = 0;
            this.labelControl1.Text = "Название:";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Image = global::Administrator.Properties.Resources.delete_16_16;
            this.CancelButton.Location = new System.Drawing.Point(389, 597);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            // 
            // SaveButton
            // 
            this.SaveButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.SaveButton.Image = global::Administrator.Properties.Resources.check_16_16;
            this.SaveButton.Location = new System.Drawing.Point(294, 597);
            this.SaveButton.Name = "SaveButton";
            this.SaveButton.Size = new System.Drawing.Size(89, 23);
            this.SaveButton.TabIndex = 3;
            this.SaveButton.Text = "Сохранить";
            this.SaveButton.Click += new System.EventHandler(this.SaveButton_Click);
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.EventManager);
            this.groupControl3.Controls.Add(this.EventOrganization);
            this.groupControl3.Controls.Add(this.EventContactPerson);
            this.groupControl3.Controls.Add(this.labelControl7);
            this.groupControl3.Controls.Add(this.labelControl6);
            this.groupControl3.Controls.Add(this.labelControl5);
            this.groupControl3.Location = new System.Drawing.Point(13, 150);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(452, 103);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Контакты";
            // 
            // EventOrganization
            // 
            this.EventOrganization.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventOrganization.Location = new System.Drawing.Point(120, 23);
            this.EventOrganization.Name = "EventOrganization";
            this.EventOrganization.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.EventOrganization.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EventOrganization.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrganizationID", "OrganizationId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("ShortName", "Название"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("Name", "Полное название")});
            this.EventOrganization.Properties.DisplayMember = "ShortName";
            this.EventOrganization.Properties.NullText = "";
            this.EventOrganization.Properties.ValueMember = "OrganizationID";
            this.ErrorProvider.SetRequired(this.EventOrganization, false);
            this.EventOrganization.Size = new System.Drawing.Size(327, 20);
            this.EventOrganization.TabIndex = 3;
            // 
            // EventContactPerson
            // 
            this.EventContactPerson.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventContactPerson.Location = new System.Drawing.Point(120, 49);
            this.EventContactPerson.Name = "EventContactPerson";
            this.EventContactPerson.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.EventContactPerson.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EventContactPerson.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Ф.И.О", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrganizationName", "Организация"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonID", "personId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.EventContactPerson.Properties.DisplayMember = "FullName";
            this.EventContactPerson.Properties.NullText = "";
            this.EventContactPerson.Properties.ValueMember = "PersonID";
            this.ErrorProvider.SetRequired(this.EventContactPerson, false);
            this.EventContactPerson.Size = new System.Drawing.Size(327, 20);
            this.EventContactPerson.TabIndex = 1;
            // 
            // labelControl7
            // 
            this.labelControl7.Location = new System.Drawing.Point(5, 52);
            this.labelControl7.Name = "labelControl7";
            this.labelControl7.Size = new System.Drawing.Size(92, 13);
            this.labelControl7.TabIndex = 2;
            this.labelControl7.Text = "Контактное лицо:";
            // 
            // labelControl6
            // 
            this.labelControl6.Location = new System.Drawing.Point(5, 78);
            this.labelControl6.Name = "labelControl6";
            this.labelControl6.Size = new System.Drawing.Size(57, 13);
            this.labelControl6.TabIndex = 1;
            this.labelControl6.Text = "Менеджер:";
            // 
            // labelControl5
            // 
            this.labelControl5.Location = new System.Drawing.Point(5, 26);
            this.labelControl5.Name = "labelControl5";
            this.labelControl5.Size = new System.Drawing.Size(70, 13);
            this.labelControl5.TabIndex = 0;
            this.labelControl5.Text = "Организация:";
            // 
            // ErrorProvider
            // 
            this.ErrorProvider.BlinkStyle = System.Windows.Forms.ErrorBlinkStyle.NeverBlink;
            this.ErrorProvider.ContainerControl = this;
            this.ErrorProvider.IgnoreOnCancel = true;
            // 
            // ReviewEdit
            // 
            this.ReviewEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewEdit.Location = new System.Drawing.Point(0, 0);
            this.ReviewEdit.Name = "ReviewEdit";
            this.ErrorProvider.SetRequired(this.ReviewEdit, false);
            this.ReviewEdit.Size = new System.Drawing.Size(443, 192);
            this.ReviewEdit.TabIndex = 1;
            // 
            // EventDescription
            // 
            this.EventDescription.Dock = System.Windows.Forms.DockStyle.Fill;
            this.EventDescription.Location = new System.Drawing.Point(0, 0);
            this.EventDescription.Name = "EventDescription";
            this.ErrorProvider.SetRequired(this.EventDescription, false);
            this.EventDescription.Size = new System.Drawing.Size(443, 192);
            this.EventDescription.TabIndex = 1;
            // 
            // xtraTabControl1
            // 
            this.xtraTabControl1.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.xtraTabControl1.Location = new System.Drawing.Point(13, 368);
            this.xtraTabControl1.Name = "xtraTabControl1";
            this.xtraTabControl1.SelectedTabPage = this.xtraTabPage2;
            this.xtraTabControl1.Size = new System.Drawing.Size(452, 223);
            this.xtraTabControl1.TabIndex = 6;
            this.xtraTabControl1.TabPages.AddRange(new DevExpress.XtraTab.XtraTabPage[] {
            this.xtraTabPage1,
            this.xtraTabPage2});
            // 
            // xtraTabPage2
            // 
            this.xtraTabPage2.Controls.Add(this.ReviewEdit);
            this.xtraTabPage2.Name = "xtraTabPage2";
            this.xtraTabPage2.Size = new System.Drawing.Size(443, 192);
            this.xtraTabPage2.Text = "Отзыв\\Причина отказа";
            // 
            // xtraTabPage1
            // 
            this.xtraTabPage1.Controls.Add(this.EventDescription);
            this.xtraTabPage1.Name = "xtraTabPage1";
            this.xtraTabPage1.Size = new System.Drawing.Size(443, 192);
            this.xtraTabPage1.Text = "Заметки";
            // 
            // BalanceControl
            // 
            this.BalanceControl.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceControl.CashPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.BalanceControl.Location = new System.Drawing.Point(13, 260);
            this.BalanceControl.Loss = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.BalanceControl.MinimumSize = new System.Drawing.Size(357, 105);
            this.BalanceControl.Name = "BalanceControl";
            this.BalanceControl.NonCashPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.BalanceControl.Size = new System.Drawing.Size(452, 105);
            this.BalanceControl.TabIndex = 7;
            // 
            // EventManager
            // 
            this.EventManager.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.EventManager.Location = new System.Drawing.Point(119, 75);
            this.EventManager.Name = "EventManager";
            this.EventManager.Properties.AllowNullInput = DevExpress.Utils.DefaultBoolean.True;
            this.EventManager.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton(DevExpress.XtraEditors.Controls.ButtonPredefines.Combo)});
            this.EventManager.Properties.Columns.AddRange(new DevExpress.XtraEditors.Controls.LookUpColumnInfo[] {
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("FullName", "Ф.И.О", 20, DevExpress.Utils.FormatType.None, "", true, DevExpress.Utils.HorzAlignment.Default, DevExpress.Data.ColumnSortOrder.Ascending),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("OrganizationName", "Организация"),
            new DevExpress.XtraEditors.Controls.LookUpColumnInfo("PersonID", "personId", 20, DevExpress.Utils.FormatType.None, "", false, DevExpress.Utils.HorzAlignment.Default)});
            this.EventManager.Properties.DisplayMember = "FullName";
            this.EventManager.Properties.NullText = "";
            this.EventManager.Properties.ValueMember = "PersonID";
            this.ErrorProvider.SetRequired(this.EventManager, false);
            this.EventManager.Size = new System.Drawing.Size(327, 20);
            this.EventManager.TabIndex = 4;
            // 
            // EventClosedDetailsFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(477, 632);
            this.Controls.Add(this.BalanceControl);
            this.Controls.Add(this.xtraTabControl1);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.SaveButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventClosedDetailsFrame";
            this.ShowIcon = false;
            this.ShowInTaskbar = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Мероприятие";
            this.Shown += new System.EventHandler(this.EventDetailsForm_Shown);
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ExitDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ExitDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDateEdit.Properties.VistaTimeProperties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.RegistrationDateEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventPersonNumber.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventType.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventName.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            this.groupControl3.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventOrganization.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventContactPerson.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ErrorProvider)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventDescription.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.xtraTabControl1)).EndInit();
            this.xtraTabControl1.ResumeLayout(false);
            this.xtraTabPage2.ResumeLayout(false);
            this.xtraTabPage1.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.EventManager.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.TextEdit EventName;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.SpinEdit EventPersonNumber;
        private DevExpress.XtraEditors.LabelControl labelControl3;
        private DevExpress.XtraEditors.ComboBoxEdit EventType;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton SaveButton;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.LabelControl labelControl7;
        private DevExpress.XtraEditors.LabelControl labelControl6;
        private DevExpress.XtraEditors.LabelControl labelControl5;
        private Controls.CustomErrorProvider ErrorProvider;
        private DevExpress.XtraEditors.LookUpEdit EventContactPerson;
        private DevExpress.XtraEditors.LabelControl labelControl8;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.DateEdit RegistrationDateEdit;
        private DevExpress.XtraEditors.DateEdit ExitDateEdit;
        private DevExpress.XtraTab.XtraTabControl xtraTabControl1;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage2;
        private DevExpress.XtraTab.XtraTabPage xtraTabPage1;
        private DevExpress.XtraEditors.MemoEdit ReviewEdit;
        private DevExpress.XtraEditors.MemoEdit EventDescription;
        private DevExpress.XtraEditors.LookUpEdit EventOrganization;
        private Administrator.Controls.BalanceControl BalanceControl;
        private DevExpress.XtraEditors.LookUpEdit EventManager;
    }
}
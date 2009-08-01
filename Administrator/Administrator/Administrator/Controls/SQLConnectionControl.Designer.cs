namespace Administrator.Controls
{
    partial class SQLConnectionControl
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
            this.ParamsGroup = new DevExpress.XtraEditors.GroupControl();
            this.TimeoutConnectLabel = new System.Windows.Forms.Label();
            this.TimeoutConnectEdit = new DevExpress.XtraEditors.TextEdit();
            this.ConnectGroup = new DevExpress.XtraEditors.GroupControl();
            this.HostEdit = new DevExpress.XtraEditors.TextEdit();
            this.DatabaseEdit = new DevExpress.XtraEditors.TextEdit();
            this.HostLabel = new System.Windows.Forms.Label();
            this.DatabaseLabel = new System.Windows.Forms.Label();
            this.PasswordEdit = new DevExpress.XtraEditors.TextEdit();
            this.IntegratedAuthCheck = new DevExpress.XtraEditors.CheckEdit();
            this.AuthGroup = new DevExpress.XtraEditors.GroupControl();
            this.PasswordLabel = new System.Windows.Forms.Label();
            this.UserEdit = new DevExpress.XtraEditors.TextEdit();
            this.UserLabel = new System.Windows.Forms.Label();
            ((System.ComponentModel.ISupportInitialize)(this.ParamsGroup)).BeginInit();
            this.ParamsGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutConnectEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectGroup)).BeginInit();
            this.ConnectGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratedAuthCheck.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthGroup)).BeginInit();
            this.AuthGroup.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // ParamsGroup
            // 
            this.ParamsGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ParamsGroup.Controls.Add(this.TimeoutConnectLabel);
            this.ParamsGroup.Controls.Add(this.TimeoutConnectEdit);
            this.ParamsGroup.Location = new System.Drawing.Point(3, 186);
            this.ParamsGroup.Name = "ParamsGroup";
            this.ParamsGroup.Size = new System.Drawing.Size(351, 49);
            this.ParamsGroup.TabIndex = 5;
            this.ParamsGroup.Text = "Параметры";
            // 
            // TimeoutConnectLabel
            // 
            this.TimeoutConnectLabel.AutoSize = true;
            this.TimeoutConnectLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.TimeoutConnectLabel.Location = new System.Drawing.Point(3, 26);
            this.TimeoutConnectLabel.Name = "TimeoutConnectLabel";
            this.TimeoutConnectLabel.Size = new System.Drawing.Size(112, 13);
            this.TimeoutConnectLabel.TabIndex = 0;
            this.TimeoutConnectLabel.Text = "Таймаут соединения";
            // 
            // TimeoutConnectEdit
            // 
            this.TimeoutConnectEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.TimeoutConnectEdit.EditValue = "";
            this.TimeoutConnectEdit.Location = new System.Drawing.Point(150, 23);
            this.TimeoutConnectEdit.Name = "TimeoutConnectEdit";
            this.TimeoutConnectEdit.Properties.DisplayFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TimeoutConnectEdit.Properties.EditFormat.FormatType = DevExpress.Utils.FormatType.Numeric;
            this.TimeoutConnectEdit.Size = new System.Drawing.Size(196, 20);
            this.TimeoutConnectEdit.TabIndex = 0;
            // 
            // ConnectGroup
            // 
            this.ConnectGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.ConnectGroup.Controls.Add(this.HostEdit);
            this.ConnectGroup.Controls.Add(this.DatabaseEdit);
            this.ConnectGroup.Controls.Add(this.HostLabel);
            this.ConnectGroup.Controls.Add(this.DatabaseLabel);
            this.ConnectGroup.Location = new System.Drawing.Point(3, 0);
            this.ConnectGroup.Name = "ConnectGroup";
            this.ConnectGroup.Size = new System.Drawing.Size(351, 75);
            this.ConnectGroup.TabIndex = 0;
            this.ConnectGroup.Text = "Соединение";
            // 
            // HostEdit
            // 
            this.HostEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.HostEdit.Location = new System.Drawing.Point(150, 23);
            this.HostEdit.Name = "HostEdit";
            this.HostEdit.Size = new System.Drawing.Size(196, 20);
            this.HostEdit.TabIndex = 0;
            // 
            // DatabaseEdit
            // 
            this.DatabaseEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.DatabaseEdit.Location = new System.Drawing.Point(150, 49);
            this.DatabaseEdit.Name = "DatabaseEdit";
            this.DatabaseEdit.Size = new System.Drawing.Size(196, 20);
            this.DatabaseEdit.TabIndex = 1;
            // 
            // HostLabel
            // 
            this.HostLabel.AutoSize = true;
            this.HostLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.HostLabel.Location = new System.Drawing.Point(3, 26);
            this.HostLabel.Name = "HostLabel";
            this.HostLabel.Size = new System.Drawing.Size(82, 13);
            this.HostLabel.TabIndex = 2;
            this.HostLabel.Text = "Адрес сервера";
            // 
            // DatabaseLabel
            // 
            this.DatabaseLabel.AutoSize = true;
            this.DatabaseLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.DatabaseLabel.Location = new System.Drawing.Point(3, 52);
            this.DatabaseLabel.Name = "DatabaseLabel";
            this.DatabaseLabel.Size = new System.Drawing.Size(72, 13);
            this.DatabaseLabel.TabIndex = 4;
            this.DatabaseLabel.Text = "База данных";
            // 
            // PasswordEdit
            // 
            this.PasswordEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.PasswordEdit.Location = new System.Drawing.Point(150, 49);
            this.PasswordEdit.Name = "PasswordEdit";
            this.PasswordEdit.Properties.PasswordChar = '*';
            this.PasswordEdit.Size = new System.Drawing.Size(196, 20);
            this.PasswordEdit.TabIndex = 1;
            // 
            // IntegratedAuthCheck
            // 
            this.IntegratedAuthCheck.Location = new System.Drawing.Point(6, 75);
            this.IntegratedAuthCheck.Name = "IntegratedAuthCheck";
            this.IntegratedAuthCheck.Properties.Caption = "Системная авторизация";
            this.IntegratedAuthCheck.Size = new System.Drawing.Size(172, 19);
            this.IntegratedAuthCheck.TabIndex = 4;
            this.IntegratedAuthCheck.CheckedChanged += new System.EventHandler(this.IntegratedAuthCheck_CheckedChanged);
            // 
            // AuthGroup
            // 
            this.AuthGroup.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.AuthGroup.Controls.Add(this.IntegratedAuthCheck);
            this.AuthGroup.Controls.Add(this.PasswordEdit);
            this.AuthGroup.Controls.Add(this.PasswordLabel);
            this.AuthGroup.Controls.Add(this.UserEdit);
            this.AuthGroup.Controls.Add(this.UserLabel);
            this.AuthGroup.Location = new System.Drawing.Point(3, 81);
            this.AuthGroup.Name = "AuthGroup";
            this.AuthGroup.Size = new System.Drawing.Size(351, 99);
            this.AuthGroup.TabIndex = 1;
            this.AuthGroup.Text = "Авторизация";
            // 
            // PasswordLabel
            // 
            this.PasswordLabel.AutoSize = true;
            this.PasswordLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.PasswordLabel.Location = new System.Drawing.Point(3, 52);
            this.PasswordLabel.Name = "PasswordLabel";
            this.PasswordLabel.Size = new System.Drawing.Size(44, 13);
            this.PasswordLabel.TabIndex = 2;
            this.PasswordLabel.Text = "Пароль";
            // 
            // UserEdit
            // 
            this.UserEdit.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.UserEdit.Location = new System.Drawing.Point(150, 23);
            this.UserEdit.Name = "UserEdit";
            this.UserEdit.Size = new System.Drawing.Size(196, 20);
            this.UserEdit.TabIndex = 0;
            // 
            // UserLabel
            // 
            this.UserLabel.AutoSize = true;
            this.UserLabel.ImeMode = System.Windows.Forms.ImeMode.NoControl;
            this.UserLabel.Location = new System.Drawing.Point(3, 26);
            this.UserLabel.Name = "UserLabel";
            this.UserLabel.Size = new System.Drawing.Size(79, 13);
            this.UserLabel.TabIndex = 0;
            this.UserLabel.Text = "Пользователь";
            // 
            // SQLConnectionControl
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.Controls.Add(this.ParamsGroup);
            this.Controls.Add(this.ConnectGroup);
            this.Controls.Add(this.AuthGroup);
            this.Name = "SQLConnectionControl";
            this.Size = new System.Drawing.Size(354, 239);
            ((System.ComponentModel.ISupportInitialize)(this.ParamsGroup)).EndInit();
            this.ParamsGroup.ResumeLayout(false);
            this.ParamsGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.TimeoutConnectEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.ConnectGroup)).EndInit();
            this.ConnectGroup.ResumeLayout(false);
            this.ConnectGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.HostEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.DatabaseEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.PasswordEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.IntegratedAuthCheck.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.AuthGroup)).EndInit();
            this.AuthGroup.ResumeLayout(false);
            this.AuthGroup.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.UserEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl ParamsGroup;
        private System.Windows.Forms.Label TimeoutConnectLabel;
        private DevExpress.XtraEditors.TextEdit TimeoutConnectEdit;
        private DevExpress.XtraEditors.GroupControl ConnectGroup;
        private DevExpress.XtraEditors.TextEdit HostEdit;
        private DevExpress.XtraEditors.TextEdit DatabaseEdit;
        private System.Windows.Forms.Label HostLabel;
        private System.Windows.Forms.Label DatabaseLabel;
        private DevExpress.XtraEditors.TextEdit PasswordEdit;
        private DevExpress.XtraEditors.CheckEdit IntegratedAuthCheck;
        private DevExpress.XtraEditors.GroupControl AuthGroup;
        private System.Windows.Forms.Label PasswordLabel;
        private DevExpress.XtraEditors.TextEdit UserEdit;
        private System.Windows.Forms.Label UserLabel;
    }
}

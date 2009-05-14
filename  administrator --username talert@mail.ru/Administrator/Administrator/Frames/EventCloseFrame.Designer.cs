namespace Administrator.Frames
{
    partial class EventCloseFrame
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
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ReviewEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ClouseButton = new DevExpress.XtraEditors.SimpleButton();
            this.RefuseButton = new DevExpress.XtraEditors.SimpleButton();
            this.BalanceControl = new Administrator.Controls.BalanceControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewEdit.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Image = global::Administrator.Properties.Resources.delete_16_16;
            this.CancelButton.Location = new System.Drawing.Point(13, 447);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(80, 23);
            this.CancelButton.TabIndex = 4;
            this.CancelButton.Text = "Отмена";
            // 
            // groupControl3
            // 
            this.groupControl3.Anchor = ((System.Windows.Forms.AnchorStyles)((((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Bottom)
                        | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl3.Controls.Add(this.ReviewEdit);
            this.groupControl3.Location = new System.Drawing.Point(13, 121);
            this.groupControl3.Name = "groupControl3";
            this.groupControl3.Size = new System.Drawing.Size(358, 320);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Отзыв \\ Причина отказа";
            // 
            // ReviewEdit
            // 
            this.ReviewEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewEdit.Location = new System.Drawing.Point(2, 20);
            this.ReviewEdit.Name = "ReviewEdit";
            this.ReviewEdit.Size = new System.Drawing.Size(354, 298);
            this.ReviewEdit.TabIndex = 0;
            // 
            // ClouseButton
            // 
            this.ClouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.ClouseButton.Image = global::Administrator.Properties.Resources.check_16_16;
            this.ClouseButton.Location = new System.Drawing.Point(296, 447);
            this.ClouseButton.Name = "ClouseButton";
            this.ClouseButton.Size = new System.Drawing.Size(75, 23);
            this.ClouseButton.TabIndex = 3;
            this.ClouseButton.Text = "Закрыть";
            this.ClouseButton.Click += new System.EventHandler(this.ClouseButton_Click);
            // 
            // RefuseButton
            // 
            this.RefuseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.RefuseButton.Image = global::Administrator.Properties.Resources.nav_down_red_16_16;
            this.RefuseButton.Location = new System.Drawing.Point(215, 447);
            this.RefuseButton.Name = "RefuseButton";
            this.RefuseButton.Size = new System.Drawing.Size(75, 23);
            this.RefuseButton.TabIndex = 2;
            this.RefuseButton.Text = "Отказ";
            this.RefuseButton.Click += new System.EventHandler(this.RefuseButton_Click);
            // 
            // BalanceControl
            // 
            this.BalanceControl.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.BalanceControl.CashPrice = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.BalanceControl.Location = new System.Drawing.Point(13, 13);
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
            this.BalanceControl.Size = new System.Drawing.Size(358, 105);
            this.BalanceControl.TabIndex = 5;
            // 
            // EventCloseFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(383, 482);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.BalanceControl);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ClouseButton);
            this.Controls.Add(this.RefuseButton);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventCloseFrame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закрыть мероприятие";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewEdit.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton RefuseButton;
        private DevExpress.XtraEditors.SimpleButton ClouseButton;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit ReviewEdit;
        private Administrator.Controls.BalanceControl BalanceControl;
    }
}
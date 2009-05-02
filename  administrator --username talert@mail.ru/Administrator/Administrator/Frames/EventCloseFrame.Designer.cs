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
            this.groupControl1 = new DevExpress.XtraEditors.GroupControl();
            this.balanceLabel = new DevExpress.XtraEditors.LabelControl();
            this.labelControl2 = new DevExpress.XtraEditors.LabelControl();
            this.EventLoss = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl1 = new DevExpress.XtraEditors.LabelControl();
            this.EventCashPrice = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl4 = new DevExpress.XtraEditors.LabelControl();
            this.CancelButton = new DevExpress.XtraEditors.SimpleButton();
            this.groupControl3 = new DevExpress.XtraEditors.GroupControl();
            this.ReviewEdit = new DevExpress.XtraEditors.MemoEdit();
            this.ClouseButton = new DevExpress.XtraEditors.SimpleButton();
            this.RefuseButton = new DevExpress.XtraEditors.SimpleButton();
            this.EventNonCashPrice = new DevExpress.XtraEditors.SpinEdit();
            this.labelControl3 = new DevExpress.XtraEditors.LabelControl();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).BeginInit();
            this.groupControl1.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventLoss.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventCashPrice.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).BeginInit();
            this.groupControl3.SuspendLayout();
            ((System.ComponentModel.ISupportInitialize)(this.ReviewEdit.Properties)).BeginInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventNonCashPrice.Properties)).BeginInit();
            this.SuspendLayout();
            // 
            // groupControl1
            // 
            this.groupControl1.Anchor = ((System.Windows.Forms.AnchorStyles)(((System.Windows.Forms.AnchorStyles.Top | System.Windows.Forms.AnchorStyles.Left)
                        | System.Windows.Forms.AnchorStyles.Right)));
            this.groupControl1.Controls.Add(this.EventNonCashPrice);
            this.groupControl1.Controls.Add(this.labelControl3);
            this.groupControl1.Controls.Add(this.balanceLabel);
            this.groupControl1.Controls.Add(this.labelControl2);
            this.groupControl1.Controls.Add(this.EventLoss);
            this.groupControl1.Controls.Add(this.labelControl1);
            this.groupControl1.Controls.Add(this.EventCashPrice);
            this.groupControl1.Controls.Add(this.labelControl4);
            this.groupControl1.Location = new System.Drawing.Point(13, 13);
            this.groupControl1.Name = "groupControl1";
            this.groupControl1.Size = new System.Drawing.Size(352, 102);
            this.groupControl1.TabIndex = 0;
            this.groupControl1.Text = "Баланс";
            // 
            // balanceLabel
            // 
            this.balanceLabel.Appearance.Font = new System.Drawing.Font("Tahoma", 12F);
            this.balanceLabel.Appearance.Options.UseFont = true;
            this.balanceLabel.Location = new System.Drawing.Point(99, 75);
            this.balanceLabel.Name = "balanceLabel";
            this.balanceLabel.Size = new System.Drawing.Size(9, 19);
            this.balanceLabel.TabIndex = 13;
            this.balanceLabel.Text = "0";
            // 
            // labelControl2
            // 
            this.labelControl2.Location = new System.Drawing.Point(5, 80);
            this.labelControl2.Name = "labelControl2";
            this.labelControl2.Size = new System.Drawing.Size(42, 13);
            this.labelControl2.TabIndex = 12;
            this.labelControl2.Text = "Баланс: ";
            // 
            // EventLoss
            // 
            this.EventLoss.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EventLoss.Location = new System.Drawing.Point(259, 23);
            this.EventLoss.Name = "EventLoss";
            this.EventLoss.Properties.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.EventLoss.Properties.Appearance.Options.UseForeColor = true;
            this.EventLoss.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EventLoss.Properties.Mask.EditMask = "c0";
            this.EventLoss.Size = new System.Drawing.Size(88, 20);
            this.EventLoss.TabIndex = 1;
            this.EventLoss.EditValueChanged += new System.EventHandler(this.EventLoss_EditValueChanged);
            // 
            // labelControl1
            // 
            this.labelControl1.Appearance.ForeColor = System.Drawing.Color.DarkRed;
            this.labelControl1.Appearance.Options.UseForeColor = true;
            this.labelControl1.Location = new System.Drawing.Point(205, 26);
            this.labelControl1.Name = "labelControl1";
            this.labelControl1.Size = new System.Drawing.Size(38, 13);
            this.labelControl1.TabIndex = 10;
            this.labelControl1.Text = "Ущерб:";
            // 
            // EventCashPrice
            // 
            this.EventCashPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EventCashPrice.Location = new System.Drawing.Point(99, 23);
            this.EventCashPrice.Name = "EventCashPrice";
            this.EventCashPrice.Properties.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.EventCashPrice.Properties.Appearance.Options.UseForeColor = true;
            this.EventCashPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EventCashPrice.Properties.Mask.EditMask = "c0";
            this.EventCashPrice.Size = new System.Drawing.Size(88, 20);
            this.EventCashPrice.TabIndex = 0;
            this.EventCashPrice.EditValueChanged += new System.EventHandler(this.EventPrice_EditValueChanged);
            // 
            // labelControl4
            // 
            this.labelControl4.Appearance.ForeColor = System.Drawing.Color.DarkGreen;
            this.labelControl4.Appearance.Options.UseForeColor = true;
            this.labelControl4.Location = new System.Drawing.Point(5, 26);
            this.labelControl4.Name = "labelControl4";
            this.labelControl4.Size = new System.Drawing.Size(78, 13);
            this.labelControl4.TabIndex = 8;
            this.labelControl4.Text = "Прибыль (нал):";
            // 
            // CancelButton
            // 
            this.CancelButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Right)));
            this.CancelButton.DialogResult = System.Windows.Forms.DialogResult.Cancel;
            this.CancelButton.Image = global::Administrator.Properties.Resources.delete_16_16;
            this.CancelButton.Location = new System.Drawing.Point(290, 447);
            this.CancelButton.Name = "CancelButton";
            this.CancelButton.Size = new System.Drawing.Size(75, 23);
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
            this.groupControl3.Size = new System.Drawing.Size(352, 320);
            this.groupControl3.TabIndex = 1;
            this.groupControl3.Text = "Отзыв \\ Причина отказа";
            // 
            // ReviewEdit
            // 
            this.ReviewEdit.Dock = System.Windows.Forms.DockStyle.Fill;
            this.ReviewEdit.Location = new System.Drawing.Point(2, 20);
            this.ReviewEdit.Name = "ReviewEdit";
            this.ReviewEdit.Size = new System.Drawing.Size(348, 298);
            this.ReviewEdit.TabIndex = 0;
            // 
            // ClouseButton
            // 
            this.ClouseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.ClouseButton.Image = global::Administrator.Properties.Resources.check_16_16;
            this.ClouseButton.Location = new System.Drawing.Point(95, 447);
            this.ClouseButton.Name = "ClouseButton";
            this.ClouseButton.Size = new System.Drawing.Size(75, 23);
            this.ClouseButton.TabIndex = 3;
            this.ClouseButton.Text = "Закрыть";
            this.ClouseButton.Click += new System.EventHandler(this.ClouseButton_Click);
            // 
            // RefuseButton
            // 
            this.RefuseButton.Anchor = ((System.Windows.Forms.AnchorStyles)((System.Windows.Forms.AnchorStyles.Bottom | System.Windows.Forms.AnchorStyles.Left)));
            this.RefuseButton.Image = global::Administrator.Properties.Resources.nav_down_red_16_16;
            this.RefuseButton.Location = new System.Drawing.Point(13, 447);
            this.RefuseButton.Name = "RefuseButton";
            this.RefuseButton.Size = new System.Drawing.Size(75, 23);
            this.RefuseButton.TabIndex = 2;
            this.RefuseButton.Text = "Отказ";
            this.RefuseButton.Click += new System.EventHandler(this.RefuseButton_Click);
            // 
            // EventNonCashPrice
            // 
            this.EventNonCashPrice.EditValue = new decimal(new int[] {
            0,
            0,
            0,
            0});
            this.EventNonCashPrice.Location = new System.Drawing.Point(99, 49);
            this.EventNonCashPrice.Name = "EventNonCashPrice";
            this.EventNonCashPrice.Properties.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.EventNonCashPrice.Properties.Appearance.Options.UseForeColor = true;
            this.EventNonCashPrice.Properties.Buttons.AddRange(new DevExpress.XtraEditors.Controls.EditorButton[] {
            new DevExpress.XtraEditors.Controls.EditorButton()});
            this.EventNonCashPrice.Properties.Mask.EditMask = "c0";
            this.EventNonCashPrice.Size = new System.Drawing.Size(88, 20);
            this.EventNonCashPrice.TabIndex = 14;
            this.EventNonCashPrice.EditValueChanged += new System.EventHandler(this.EventNonCashPrice_EditValueChanged);
            // 
            // labelControl3
            // 
            this.labelControl3.Appearance.ForeColor = System.Drawing.Color.MidnightBlue;
            this.labelControl3.Appearance.Options.UseForeColor = true;
            this.labelControl3.Location = new System.Drawing.Point(5, 52);
            this.labelControl3.Name = "labelControl3";
            this.labelControl3.Size = new System.Drawing.Size(88, 13);
            this.labelControl3.TabIndex = 15;
            this.labelControl3.Text = "Прибыль (б/нал):";
            // 
            // EventCloseFrame
            // 
            this.AutoScaleDimensions = new System.Drawing.SizeF(6F, 13F);
            this.AutoScaleMode = System.Windows.Forms.AutoScaleMode.Font;
            this.ClientSize = new System.Drawing.Size(377, 482);
            this.Controls.Add(this.groupControl3);
            this.Controls.Add(this.ClouseButton);
            this.Controls.Add(this.RefuseButton);
            this.Controls.Add(this.CancelButton);
            this.Controls.Add(this.groupControl1);
            this.FormBorderStyle = System.Windows.Forms.FormBorderStyle.FixedDialog;
            this.MaximizeBox = false;
            this.MinimizeBox = false;
            this.Name = "EventCloseFrame";
            this.ShowIcon = false;
            this.StartPosition = System.Windows.Forms.FormStartPosition.CenterParent;
            this.Text = "Закрыть мероприятие";
            ((System.ComponentModel.ISupportInitialize)(this.groupControl1)).EndInit();
            this.groupControl1.ResumeLayout(false);
            this.groupControl1.PerformLayout();
            ((System.ComponentModel.ISupportInitialize)(this.EventLoss.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventCashPrice.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.groupControl3)).EndInit();
            this.groupControl3.ResumeLayout(false);
            ((System.ComponentModel.ISupportInitialize)(this.ReviewEdit.Properties)).EndInit();
            ((System.ComponentModel.ISupportInitialize)(this.EventNonCashPrice.Properties)).EndInit();
            this.ResumeLayout(false);

        }

        #endregion

        private DevExpress.XtraEditors.GroupControl groupControl1;
        private DevExpress.XtraEditors.SpinEdit EventCashPrice;
        private DevExpress.XtraEditors.LabelControl labelControl4;
        private DevExpress.XtraEditors.SpinEdit EventLoss;
        private DevExpress.XtraEditors.LabelControl labelControl1;
        private DevExpress.XtraEditors.SimpleButton CancelButton;
        private DevExpress.XtraEditors.SimpleButton RefuseButton;
        private DevExpress.XtraEditors.SimpleButton ClouseButton;
        private DevExpress.XtraEditors.GroupControl groupControl3;
        private DevExpress.XtraEditors.MemoEdit ReviewEdit;
        private DevExpress.XtraEditors.LabelControl labelControl2;
        private DevExpress.XtraEditors.LabelControl balanceLabel;
        private DevExpress.XtraEditors.SpinEdit EventNonCashPrice;
        private DevExpress.XtraEditors.LabelControl labelControl3;
    }
}
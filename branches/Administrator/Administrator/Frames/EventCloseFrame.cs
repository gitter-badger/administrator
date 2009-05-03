using System;
using System.Drawing;
using System.Windows.Forms;

namespace Administrator.Frames
{
    public partial class EventCloseFrame : BaseFrame
    {
        public EventCloseFrame()
        {
            InitializeComponent();
        }

        public Decimal CashPrice
        {
            get { return BalanceControl.CashPrice; }
        }

        public Decimal NonCashPrice
        {
            get { return BalanceControl.NonCashPrice; }
        }

        public Decimal Loss
        {
            get { return BalanceControl.Loss; }
        }

        public String Review
        {
            get { return (string)ReviewEdit.EditValue; }
        }

        private void RefuseButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            DialogResult =DialogResult.Abort;
            Close();
        }

        private void ClouseButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
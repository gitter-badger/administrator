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
            get { return (Decimal) EventCashPrice.EditValue; }
        }

        public Decimal NonCashPrice
        {
            get { return (Decimal)EventNonCashPrice.EditValue; }
        }

        public Decimal Loss
        {
            get { return (Decimal)EventLoss.EditValue; }
        }

        public String Review
        {
            get { return (string)ReviewEdit.EditValue; }
        }

        private void CalcBalance()
        {
            decimal balance = CashPrice + NonCashPrice + Loss;

            balanceLabel.Text = balance.ToString("C");

            balanceLabel.ForeColor = balance <= 0 ? Color.Red : Color.Green;
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

        private void EventPrice_EditValueChanged(object sender, EventArgs e)
        {
            CalcBalance();
        }

        private void EventLoss_EditValueChanged(object sender, EventArgs e)
        {
            CalcBalance();
        }

        private void EventNonCashPrice_EditValueChanged(object sender, EventArgs e)
        {
            CalcBalance();
        }
    }
}
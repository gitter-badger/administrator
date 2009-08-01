using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Text;
using System.Windows.Forms;
using DevExpress.XtraEditors;

namespace Administrator.Controls
{
    public partial class BalanceControl : DevExpress.XtraEditors.XtraUserControl
    {
        public BalanceControl()
        {
            InitializeComponent();
        }

        public Decimal CashPrice
        {
            get { return (Decimal)EventCashPrice.EditValue; }
            set { EventCashPrice.EditValue = value; }
        }

        public Decimal NonCashPrice
        {
            get { return (Decimal)EventNonCashPrice.EditValue; }
            set { EventNonCashPrice.EditValue = value; }
        }

        public Decimal Loss
        {
            get { return (Decimal)EventLoss.EditValue; }
            set { EventLoss.EditValue = value; }
        }

        private void CalcBalance()
        {
            CashPrice = Math.Abs(CashPrice);
            NonCashPrice = Math.Abs(NonCashPrice);
            Loss = Math.Abs(Loss);

            decimal balance = CashPrice + NonCashPrice + Loss;

            balanceLabel.Text = balance.ToString("C");

            balanceLabel.ForeColor = balance <= 0 ? Color.Red : Color.Green;
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

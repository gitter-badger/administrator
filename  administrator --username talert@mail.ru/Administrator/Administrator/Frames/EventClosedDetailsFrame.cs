using System;
using System.Drawing;
using System.Windows.Forms;
using Administrator.Objects;
using Administrator.References;
using DevExpress.XtraEditors;

namespace Administrator.Frames
{
    public partial class EventClosedDetailsFrame : XtraForm
    {
        public EventClosedDetailsFrame()
        {
            InitializeComponent();
        }

        public Event Event { get; set; }

        public Object PersonsDataSource { get; set; }
        public Object OrganizationsDataSource { get; set; }

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

        public String Review
        {
            get { return (string)ReviewEdit.EditValue; }
            set { ReviewEdit.EditValue = value; }
        }

        private void GetDataFromForm()
        {
            if (Event == null) Event = new Event { EventId = Guid.NewGuid() };

            Event.Name = EventName.EditValue as string;
            Event.Description = EventDescription.EditValue as string;
            Event.Type = EventTypeReference.GetTypeByReference(EventType.EditValue as string);
            int personNumber;
            Int32.TryParse(EventPersonNumber.EditValue.ToString(), out personNumber);
            Event.PersonNumber = personNumber;
            Event.ManagerPersonId = EventManager.EditValue == null ? Guid.Empty : (Guid)EventManager.EditValue;
            Event.ContactPersonId = EventContactPerson.EditValue == null ? Guid.Empty : (Guid)EventContactPerson.EditValue;
            Event.OrganizationId = EventOrganization.EditValue == null ? Guid.Empty : (Guid)EventOrganization.EditValue;
            Event.RegistrationDate = RegistrationDateEdit.EditValue == null
                                         ? DateTime.Now
                                         : (DateTime) RegistrationDateEdit.EditValue;
            Event.ExitDate = ExitDateEdit.EditValue == null
                                         ? DateTime.Now
                                         : (DateTime)ExitDateEdit.EditValue;
            Event.CashPrice = CashPrice;
            Event.NonCashPrice = NonCashPrice;
            Event.Loss = Loss;
            Event.Review = Review;
        }
        
        private void SetFormData()
        {
            if (Event == null)
            {
                EventType.EditValue = EventTypeReference.GetEventReference(EventTypes.Unknown);
            }
            else
            {
                EventName.EditValue = Event.Name;
                EventDescription.EditValue = Event.Description;
                EventType.EditValue = EventTypeReference.GetEventReference(Event.Type);
                EventPersonNumber.EditValue = Event.PersonNumber;
                EventManager.EditValue = Event.ManagerPersonId;
                EventContactPerson.EditValue = Event.ContactPersonId;
                EventOrganization.EditValue = Event.OrganizationId;
                RegistrationDateEdit.EditValue = Event.RegistrationDate;
                ExitDateEdit.EditValue = Event.ExitDate;
                CashPrice = Event.CashPrice;
                NonCashPrice = Event.NonCashPrice;
                Loss = Event.Loss;
                Review = Event.Review;

            }
        }

        private void CalcBalance()
        {
            decimal balance = CashPrice + NonCashPrice + Loss;

            balanceLabel.Text = balance.ToString("C");

            balanceLabel.ForeColor = balance <= 0 ? Color.Red : Color.Green;
        }

        private void EventDetailsForm_Shown(object sender, EventArgs e)
        {
            EventType.Properties.Items.AddRange(EventTypeReference.GetEventReferences());

            EventContactPerson.Properties.DataSource = PersonsDataSource;
            EventManager.Properties.DataSource = PersonsDataSource;
            EventOrganization.Properties.DataSource = OrganizationsDataSource;
            
            SetFormData();
       }

        private void SaveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren())
            {
                return;
            }

            GetDataFromForm();

            DialogResult = DialogResult.OK;
            Close();
        }

        private void EventName_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool error = string.IsNullOrEmpty(EventName.EditValue as string);

            ErrorProvider.SetError(EventName,error?"РњРµСЂРѕРїСЂРёСЏС‚РёРµ РґРѕР»Р¶РЅРѕ РёРјРµС‚СЊ РЅР°Р·РІР°РЅРёРµ":null,true);

            e.Cancel = error;
        }

        private void ExitDateEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool error = ExitDateEdit.EditValue == null;

            ErrorProvider.SetError(ExitDateEdit, error ? "РќРµРѕР±С…РѕРґРёРјРѕ РІРІРµСЃС‚Рё РґР°С‚Сѓ РѕС‚СЉРµР·РґР°" : null, true);

            e.Cancel = error;
        }

        private void RegistrationDateEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool error = RegistrationDateEdit.EditValue == null;

            ErrorProvider.SetError(RegistrationDateEdit, error ? "РќРµРѕР±С…РѕРґРёРјРѕ РІРІРµСЃС‚Рё РґР°С‚Сѓ Р·Р°РµР·РґР°" : null, true);

            e.Cancel = error;
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
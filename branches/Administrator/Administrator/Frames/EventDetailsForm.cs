using System;
using System.Windows.Forms;
using Administrator.Objects;
using Administrator.References;
using DevExpress.XtraEditors;

namespace Administrator.Frames
{
    public partial class EventDetailsForm : XtraForm
    {
        public EventDetailsForm()
        {
            InitializeComponent();
        }

        public Event Event { get; set; }

        public Object PersonsDataSource { get; set; }
        public Object OrganizationsDataSource { get; set; }


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
            }
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

            ErrorProvider.SetError(EventName,error?"Мероприятие должно иметь название":null,true);

            e.Cancel = error;
        }

        private void ExitDateEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool error = ExitDateEdit.EditValue == null;

            ErrorProvider.SetError(ExitDateEdit, error ? "Необходимо ввести дату отъезда" : null, true);

            e.Cancel = error;
        }

        private void RegistrationDateEdit_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            bool error = RegistrationDateEdit.EditValue == null;

            ErrorProvider.SetError(RegistrationDateEdit, error ? "Необходимо ввести дату заезда" : null, true);

            e.Cancel = error;
        }



    }
}
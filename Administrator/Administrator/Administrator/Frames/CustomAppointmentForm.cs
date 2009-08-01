using System;
using System.Windows.Forms;
using Administrator.Controllers;
using Administrator.Objects;
using DevExpress.XtraScheduler;

namespace Administrator.Frames
{
    public partial class CustomAppointmentForm : DevExpress.XtraEditors.XtraForm
    {
        public EventAppointmentFormController Controller { get; private set; }

        public CustomAppointmentForm(SchedulerControl control, Appointment apt, Event ev)
        {
            Event = ev;
            InitializeComponent();

            Controller = new EventAppointmentFormController(control, apt);
        }

        private void SetDataToForm()
        {
            StartDateEdit.EditValue = Controller.Start.Date;
            StartTimeEdit.EditValue = Controller.Start.TimeOfDay;
            EndDateEdit.EditValue = Controller.End.Date;
            EndTimeEdit.EditValue = Controller.End.TimeOfDay;
            DescriptionEdit.EditValue = Controller.Description;
        }

        public Event Event { get; private set; }

        private void GetDataFromForm()
        {
            TimeSpan sSpan = StartTimeEdit.EditValue.GetType() == typeof(TimeSpan) ? (TimeSpan)StartTimeEdit.EditValue : ((DateTime)StartTimeEdit.EditValue).TimeOfDay;
            TimeSpan eSpan = EndTimeEdit.EditValue.GetType() == typeof(TimeSpan) ? (TimeSpan)EndTimeEdit.EditValue : ((DateTime)EndTimeEdit.EditValue).TimeOfDay;

            Controller.Start = (DateTime) StartDateEdit.EditValue + sSpan;
            Controller.End = (DateTime) EndDateEdit.EditValue + eSpan;
            Controller.Description = DescriptionEdit.EditValue as string;
            if(Controller.IsNewAppointment)
            {
                Controller.AppoitementId = Guid.NewGuid();
                Controller.EventId = Event.EventId;
                Controller.Subject = Event.Name;
            }
        }

        private void CustomAppointmentForm_Shown(object sender, System.EventArgs e)
        {
            SetDataToForm();
        }

        private void OkButton_Click(object sender, System.EventArgs e)
        {
            if(!ValidateChildren())
            {
                return;
            }

            GetDataFromForm();

            Controller.ApplyChanges();

            DialogResult = DialogResult.OK;
            Close();
        }
    }
}
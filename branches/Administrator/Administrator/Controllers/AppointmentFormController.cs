using System;
using DevExpress.XtraScheduler;
using DevExpress.XtraScheduler.UI;

namespace Administrator.Controllers
{
    public class EventAppointmentFormController : AppointmentFormController
    {
        public EventAppointmentFormController(SchedulerControl control, Appointment apt)
            : base(control, apt)
        {
        }

        public Guid AppoitementId { get { return (Guid)EditedAppointmentCopy.CustomFields["service_event_id"]; } set { EditedAppointmentCopy.CustomFields["service_event_id"] = value; } }
        public Guid EventId { get { return (Guid)EditedAppointmentCopy.CustomFields["event_id"]; } set { EditedAppointmentCopy.CustomFields["event_id"] = value; } }

        Guid SourceAppoitementId { get { return (Guid)SourceAppointment.CustomFields["service_event_id"]; } set { SourceAppointment.CustomFields["service_event_id"] = value; } }

        public override bool IsAppointmentChanged()
        {
            if (base.IsAppointmentChanged())
                return true;
            return AppoitementId != SourceAppoitementId;
        }

        protected override void ApplyCustomFieldsValues()
        {
            SourceAppoitementId = AppoitementId;
        }
    }
}

using System;

namespace Administrator.Objects
{
    public class EventServiceRelation : Entity
    {
        public static readonly string TableName = "service_event";

        public Guid ServiceEventId
        {
            get { return GetValue<Guid>("service_event_id"); }
            set { SetValue("service_event_id", value); }
        }

        public Guid EventId
        {
            get { return GetValue<Guid>("event_id"); }
            set { SetValue("event_id", value); }
        }

        public Guid ServiceId
        {
            get { return GetValue<Guid>("service_id"); }
            set { SetValue("service_id", value); }
        }

        public DateTime StartDate
        {
            get { return GetValue<DateTime>("start_date"); }
            set { SetValue("start_date", value); }
        }

        public DateTime EndDate
        {
            get { return GetValue<DateTime>("end_date"); }
            set { SetValue("end_date", value); }
        }

        public string Description
        {
            get { return GetValue<string>("description"); }
            set { SetValue("description", value); }
        }
    }
}

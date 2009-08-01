using System;

namespace Administrator.Objects
{
    public class Service : Entity
    {
        public static readonly string TableName = "service";

        public Guid ServiceId
        {
            get { return GetValue<Guid>("service_id"); }
            set { SetValue("service_id", value); }
        }

        public Guid ServiceTypeId
        {
            get { return GetValue<Guid>("service_type_id"); }
            set { SetValue("service_type_id", value); }
        }

        public String Name
        {
            get { return GetValue<String>("name"); }
            set { SetValue("name", value); }
        }
    }
}

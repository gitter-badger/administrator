using System;

namespace Administrator.Objects
{
    public class ServiceType : Entity
    {
        public static readonly string TableName = "service_type";

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

        public override string ToString()
        {
            return Name;
        }
    }
}

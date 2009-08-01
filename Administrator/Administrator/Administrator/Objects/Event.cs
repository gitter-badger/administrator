using System;
using Administrator.References;

namespace Administrator.Objects
{
    public  class Event :Entity
    {
        public static string TableName = "event";

        public Guid EventId
        {
            get { return GetValue<Guid>("event_id"); }
            set { SetValue("event_id", value); }
        }

        public Guid ContactPersonId
        {
            get { return GetValue<Guid>("contact_person_id"); }
            set { SetValue("contact_person_id", value); }
        }
        public Guid ManagerPersonId
        {
            get { return GetValue<Guid>("manager_person_id"); }
            set { SetValue("manager_person_id", value); }
        }

        public Guid OrganizationId
        {
            get { return GetValue<Guid>("organization_id"); }
            set { SetValue("organization_id", value); }
        }

        public DateTime RegistrationDate
        {
            get { return GetValue<DateTime>("registration_date"); }
            set { SetValue("registration_date", value); }
        }

        public DateTime ExitDate
        {
            get { return GetValue<DateTime>("exit_date"); }
            set { SetValue("exit_date", value); }
        }

        public string Name
        {
            get { return GetValue<string>("name"); }
            set { SetValue("name", value); }
        }

        public EventTypes Type
        {
            get { return GetValue<EventTypes>("type"); }
            set { SetValue("type", value); }
        }

        public EventStates State
        {
            get { return GetValue<EventStates>("state"); }
            set { SetValue("state", value); }
        }

        public int PersonNumber
        {
            get { return GetValue<int>("person_number"); }
            set { SetValue("person_number", value); }
        }
       
        public Decimal CashPrice
        {
            get { return GetValue<Decimal>("price_cash"); }
            set { SetValue("price_cash", value); }
        }

        public Decimal NonCashPrice
        {
            get { return GetValue<Decimal>("price_non_cash"); }
            set { SetValue("price_non_cash", value); }
        }

        public Decimal Loss
        {
            get { return GetValue<Decimal>("loss"); }
            set { SetValue("loss", value); }
        }

        public string Review
        {
            get { return GetValue<string>("review"); }
            set { SetValue("review", value); }
        }

        public string Description
        {
            get { return GetValue<string>("description"); }
            set { SetValue("description", value); }
        }



    }
}

using System;
using System.Drawing;

namespace Administrator.Objects
{
    public class Person : Entity
    {
        public static readonly string TableName = "person";

        public Guid PersonId
        {
            get { return GetValue<Guid>("person_id"); }
            set { SetValue("person_id", value); }
        }

        public Guid OrganizationId
        {
            get { return GetValue<Guid>("organization_id"); }
            set { SetValue("organization_id", value); }
        }

        public String FirstName
        {
            get
            {
                return GetValue<String>("first_name");
            }
            set { SetValue("first_name", value); }
        }

        public String LastName
        {
            get { return GetValue<String>("last_name"); }
            set { SetValue("last_name", value); }
        }

        public String Surname
        {
            get { return GetValue<String>("surname"); }
            set { SetValue("surname", value); }
        }

        public String Post
        {
            get { return GetValue<String>("post"); }
            set { SetValue("post", value); }
        }

        public String Phone
        {
            get { return GetValue<String>("phone"); }
            set { SetValue("phone", value); }
        }

        public String Mobile
        {
            get { return GetValue<String>("mobile"); }
            set { SetValue("mobile", value); }
        }

        public String Email
        {
            get { return GetValue<String>("email"); }
            set { SetValue("email", value); }
        }

        public String Isq
        {
            get { return GetValue<String>("icq"); }
            set { SetValue("icq", value); }
        }

        public Boolean Sex
        {
            get { return GetValue<Boolean>("sex"); }
            set { SetValue("sex", value); }
        }

        public Image Photo
        {
            get { return GetValue<Image>("image"); }
            set { SetValue("image", value); }
        }

        public Guid ImageId
        {
            get { return GetValue<Guid>("image_id"); }
            set { SetValue("image_id", value); }
        }

        public String Description
        {
            get { return GetValue<String>("description"); }
            set { SetValue("description", value); }
        }
    }
}
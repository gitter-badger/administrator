using System;
using System.Diagnostics;
using ALProjects.Core.Lookups;

namespace ALProjects.Core.Objects
{
    [DebuggerStepThrough]
    [Serializable]
    public class UserInfo
    {
        #region members

        private readonly String _addres;
        private readonly DateTime _birthDate;
        private readonly String _city;
        private readonly String _email;
        private readonly String _firstName;
        private readonly String _icq;
        private readonly Int32 _id;
        private readonly Languages _language;
        private readonly String _lastName;
        private readonly String _phone;
        private readonly String _site;

        #endregion

        #region ctor

        public UserInfo()
        {
            RegistrationDate =
                LastVisitDate = DateTime.Now;
        }

        public UserInfo(Int32 id, String firstName, String lastName, Languages language, DateTime birthDate,
                        String city, String addres, String phone, String email, String icq, String site)
        {
            _id = id;
            _firstName = firstName;
            _lastName = lastName;
            _language = language;
            _birthDate = birthDate;
            _city = city;
            _addres = addres;
            _phone = phone;
            _email = email;
            _icq = icq;
            _site = site;
        }

        #endregion

        #region public properties

        public Int32 Id
        {
            get { return _id; }
        }

        public String FirstName
        {
            get { return _firstName; }
        }

        public String LastName
        {
            get { return _lastName; }
        }

        public Languages Language
        {
            get { return _language; }
        }

        public DateTime BirthDate
        {
            get { return _birthDate; }
        }

        public String Country { get; private set; }

        public String City
        {
            get { return _city; }
        }

        public String Addres
        {
            get { return _addres; }
        }

        public String Phone
        {
            get { return _phone; }
        }

        public String Email
        {
            get { return _email; }
        }

        public String ICQ
        {
            get { return _icq; }
        }

        public String Site
        {
            get { return _site; }
        }

        public DateTime RegistrationDate { get; private set; }
        public DateTime LastVisitDate { get; private set; }

        #endregion
    }
}
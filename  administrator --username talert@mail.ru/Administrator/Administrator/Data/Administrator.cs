using System;
using System.Data.Linq;
using System.Linq;
using log4net;
using NearDupe.Data;

namespace Administrator.Data
{
    public partial class AdministratorDataContext
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(AdministratorDataContext));

        public IQueryable AllOrganizations
        {
            get { return Organizations; }
        }

        public IQueryable AllPersons
        {
            get { return PersonLists; }
        }

        public IQueryable GetOrganizationQuerry()
        {
            return GetSamleProxyQuery(OrganizationLists);
        }

        public IQueryable GetPersonsQuerry()
        {
            return GetSamleProxyQuery(PersonLists);
        }

        public bool IsOrganizationExists(Guid organizationID)
        {
            return Organizations.Where(org => org.OrganizationID == organizationID).SingleOrDefault() != null;
        }

        public void UpdateOrInsertOrganization(OrganizationList organization)
        {
            var org = Organizations.Where(o => o.OrganizationID == organization.OrganizationID).SingleOrDefault();

            if (org == null)
            {
                org = new Organization { OrganizationID = organization.OrganizationID };
                org.Address = organization.Address;
                org.Description = organization.Description;
                org.Discount = organization.Discount;
                org.Email = organization.Email;
                org.LegalAddress = organization.LegalAddress;
                org.Name = organization.Name;
                org.Phone = organization.Phone;
                org.PostAddress = organization.PostAddress;
                org.ScopeOfActivity = organization.ScopeOfActivity;
                org.ShortName = organization.ShortName;
                Organizations.InsertOnSubmit(org);
            }
            SubmitChanges();
        }

        public void UpdateOrInsertPerson(PersonList person)
        {
            if (person == null) return;

            var curPerson = Persons.Where(p => p.PersonID == person.PersonID).SingleOrDefault();

            if (curPerson == null)
            {
                curPerson = new Person {PersonID = person.PersonID};
                                
                Persons.InsertOnSubmit(curPerson);
            }

            curPerson.PersonID = person.PersonID;
            curPerson.Description = person.Description;
            curPerson.Email = person.Email;
            curPerson.FirstName = person.FirstName;
            curPerson.LastName = person.LastName;
            curPerson.Surname = person.Surname;
            curPerson.Sex = person.Sex;
            curPerson.Icq = person.Icq;
            curPerson.Phone = person.Phone;
            curPerson.Mobile = person.Mobile;

            SubmitChanges();

            UpdatePersonOrganizationRelation(person);

            UpdatePersonPhoto(curPerson, person.Image);
        }

        public void UpdateImage(Guid imageID, byte[] data, string name)
        {
            var img = Imgs.Where(i => i.ImageID == imageID).SingleOrDefault();

            if (img == null)
            {
                img = new Img { ImageID = imageID, Data = data, Name = name };
                Imgs.InsertOnSubmit(img);
            }
            else
            {
                img.Data = data;
                img.Name = name;
            }
            SubmitChanges();
        }

        public void DeleteImage(Guid imageID)
        {
            var img = Imgs.Where(i => i.ImageID == imageID).SingleOrDefault();

            if (img == null) return;

            Imgs.DeleteOnSubmit(img);
            SubmitChanges();
        }

        public void MoveToBlackList(Guid badEntityID, string reason)
        {
            if (BlackLists.Where(bl => bl.BlackListID == badEntityID).SingleOrDefault() != null) return;

            BlackLists.InsertOnSubmit(new BlackList { BlackListID = badEntityID, Date = DateTime.Now, Description = reason });

            SubmitChanges();
        }

        public void MoveFromBlackList(Guid badEntityID)
        {
            if (BlackLists.Where(bl => bl.BlackListID == badEntityID).SingleOrDefault() == null) return;

            BlackLists.DeleteOnSubmit(BlackLists.Where(bl => bl.BlackListID == badEntityID).SingleOrDefault());

            SubmitChanges();
        }

        public object[] ScopesOfActivity()
        {
            return Organizations
                .Select(org => org.ScopeOfActivity)
                .Where(val => val != null && val != string.Empty)
                .Distinct()
                .ToArray();
        }

        public object[] Posts()
        {
            return PersonOrganizationRelations
                .Select(por => por.Post)
                .Where(val => val != null && val != string.Empty)
                .Distinct()
                .ToArray();
        }

        public override void SubmitChanges(ConflictMode failureMode)
        {
            try
            {
                base.SubmitChanges(failureMode);
            }
            catch (Exception ex)
            {
                log.Error("SubmitChanges is FAILED", ex);
            }
        }

        private void UpdatePersonOrganizationRelation(PersonList person)
        {
            if (person.OrganizationID.Value == Guid.Empty) return;

            PersonOrganizationRelations.DeleteAllOnSubmit(PersonOrganizationRelations.Where(
                    directorRelation =>
                    directorRelation.OrganizationID == person.OrganizationID && directorRelation.Post.ToLower().Equals("генеральный директор")));

            PersonOrganizationRelations.DeleteAllOnSubmit(
                PersonOrganizationRelations.Where(atherPosts => atherPosts.PersonID == person.PersonID));

            SubmitChanges();

            var por = new PersonOrganizationRelation
                          {
                              OrganizationID = person.OrganizationID.Value,
                              PersonID = person.PersonID,
                              Post = person.Post
                          };

            PersonOrganizationRelations.InsertOnSubmit(por);

            SubmitChanges();
        }

        private void UpdatePersonPhoto(Person person, byte[] image)
        {
            if (!person.ImageID.HasValue)
            {
                if (image != null)
                {
                    var imgID = Guid.NewGuid();
                    person.ImageID = imgID;
                    UpdateImage(imgID, image, "Photo");
                }
            }
            else
            {
                if (image != null)
                {
                    UpdateImage(person.ImageID.Value, image, "Photo");
                }
                else
                {
                    DeleteImage(person.ImageID.Value);
                }
            }
        }

        private IQueryable GetSamleProxyQuery(IQueryable query)
        {
            var proxy = new DevExServerModeSourceQuerebleProxy(query);
            proxy.EntityQueried += ProxyEntityQueried;
            return proxy;
        }

        private void ProxyEntityQueried(object sender, EntityQueriedEventArgs e)
        {
            Refresh(RefreshMode.OverwriteCurrentValues, e.Entities);
        }

        partial void UpdatePersonList(PersonList instance)
        {
            return;
        }

    }
}
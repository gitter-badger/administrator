using System;
using System.Data.Linq;
using System.Linq;
using log4net;
using NearDupe.Data;

namespace Administrator.Data
{
    public partial class AdministratorDataContext
    {
        private static readonly ILog log = LogManager.GetLogger(typeof (AdministratorDataContext));

        public IQueryable AllOrganizations
        {
            get{ return Organizations;}
        }

        public IQueryable GetOrganizationQuerry()
        {
            var proxy = new DevExServerModeSourceQuerebleProxy(OrganizationLists);
            proxy.EntityQueried += new EntityQueriedEntityHandler(ProxyEntityQueried);
            return proxy;
        }

        public bool IsOrganizationExists(Guid organizationID)
        {
            return Organizations.Where(org => org.OrganizationID == organizationID).SingleOrDefault() != null;
        }

        public void UpdateOrInsertOrganization(OrganizationList organization)
        {
            var org = Organizations.Where(o => o.OrganizationID == organization.OrganizationID).SingleOrDefault();

            if(org == null)
            {
                org = new Organization{OrganizationID = organization.OrganizationID};
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

        public void MoveToBlackList(Guid badEntityID, string reason)
        {
            if(BlackLists.Where(bl=> bl.BlackListID == badEntityID).SingleOrDefault() != null) return;

            BlackLists.InsertOnSubmit(new BlackList {BlackListID = badEntityID, Date = DateTime.Now, Description = reason});
            
            SubmitChanges();
        }

        public void MoveFromBlackList(Guid badEntityID)
        {
            if (BlackLists.Where(bl => bl.BlackListID == badEntityID).SingleOrDefault() == null) return;

            BlackLists.DeleteOnSubmit(BlackLists.Where(bl=>bl.BlackListID == badEntityID).SingleOrDefault());

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

        public override void SubmitChanges(ConflictMode failureMode)
        {
            try
            {
                base.SubmitChanges(failureMode);
            }
            catch (Exception ex)
            {
                log.Error("SubmitChanges is FAILED",ex);
            }
        }

        private void ProxyEntityQueried(object sender, EntityQueriedEventArgs e)
        {
            Refresh(RefreshMode.OverwriteCurrentValues, e.Entities);
        }
    }
}
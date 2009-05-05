using System;
using Administrator.Data;
using Administrator.EventArgsReferences;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Administrator.Controls
{
    public partial class OrganizationDetailsControl : XtraUserControl
    {
        public event OrganizationExistanceCheckNeededEventHandler OrganizationExistanceCheckNeeded;

        private OrganizationList organization;

        public OrganizationDetailsControl()
        {
            InitializeComponent();
        }

        public Object[] ScopeOfActitvityList
        {
            set { scopeOfActivityEdit.Properties.Items.AddRange(value); }
        }

        public OrganizationList Organization
        {
            get
            {
                GetOrganizationInfo();
                return organization;
            } 
            set
            {
                organization = value;
                SetOganizationInfo();
            }
        }

        private void OnOrganizationExistanceCheckNeeded(OrganizationExistanceCheckNeededEventArgs e)
        {
            OrganizationExistanceCheckNeededEventHandler needed = OrganizationExistanceCheckNeeded;
            if (needed != null) needed(this, e);
        }

        private void GetOrganizationInfo()
        {
            organization.Address = (addressEdit.EditValue as string);
            organization.Description = (descriptionEdit.EditValue as string);
            organization.Discount = (decimal)discauntSpinEdit.EditValue;
            organization.Email = (emailEdit.EditValue as string);
            organization.LegalAddress = (legalAddresEdit.EditValue as string);
            organization.Name = (fullNameEdit.EditValue as string);
            organization.ShortName = (shortNameEdit.EditValue as string);
            organization.Phone = (phoneEdit.EditValue as string);
            organization.PostAddress = (postAddressEdit.EditValue as string);
            organization.ScopeOfActivity = (scopeOfActivityEdit.EditValue as string);
        }

        private void SetOganizationInfo()
        {
            addressEdit.EditValue = organization.Address;
            descriptionEdit.EditValue = organization.Description;
            discauntSpinEdit.EditValue = organization.Discount.HasValue?organization.Discount:0;
            emailEdit.EditValue = organization.Email;
            legalAddresEdit.EditValue = organization.LegalAddress;
            fullNameEdit.EditValue = organization.Name;
            shortNameEdit.EditValue = organization.ShortName;
            phoneEdit.EditValue = organization.Phone;
            postAddressEdit.EditValue = organization.PostAddress;
            scopeOfActivityEdit.EditValue = organization.ScopeOfActivity;
            directorNameEdit.EditValue = Organization.Director;
        }

        private void OrganizationDetailsControl_Validating(object sender, System.ComponentModel.CancelEventArgs e)
        {
            var fullNameError = String.IsNullOrEmpty(fullNameEdit.EditValue as string);

            ErrorProvider.SetError(fullNameEdit, fullNameError ? "Необходимо ввести полное название организации" : null, true);
            
            var shortNameError = string.IsNullOrEmpty(shortNameEdit.EditValue as string);

            ErrorProvider.SetError(shortNameEdit, shortNameError ? "Необходимо ввести короткое название организации" : null, true);

            e.Cancel = fullNameError || shortNameError;

            if (!e.Cancel)
            {
                var existanceCheck =
                    new OrganizationExistanceCheckNeededEventArgs(new Organization
                                                                      {
                                                                          Name = fullNameEdit.EditValue as string,
                                                                          ShortName = shortNameEdit.EditValue as string
                                                                      });
                OnOrganizationExistanceCheckNeeded(existanceCheck);

                ErrorProvider.SetError(fullNameEdit, existanceCheck.Exists ? "Организация с таким или похожим именем уже существует." : null, true);
                ErrorProvider.SetError(shortNameEdit, existanceCheck.Exists ? "Организация с таким или похожим именем уже существует." : null, true);

                e.Cancel = existanceCheck.Exists;
            }
        }

        #region addresses sinchronization
        private bool needSinchronizeAddresses;
        private void legalAddresEdit_EditValueChanging(object sender, ChangingEventArgs e)
        {
            if (!needSinchronizeAddresses) 
            {
                needSinchronizeAddresses = (string.IsNullOrEmpty(addressEdit.EditValue as string)&&string.IsNullOrEmpty(legalAddresEdit.EditValue as string)
                    || (addressEdit.EditValue.Equals(e.OldValue)));
            }

            if(!needSinchronizeAddresses) return;

            addressEdit.EditValue = e.NewValue;
        }

        private void legalAddresEdit_EditValueChanged(object sender, EventArgs e)
        {
            needSinchronizeAddresses = false;
        }
        #endregion addresses sinchronization
    }
}

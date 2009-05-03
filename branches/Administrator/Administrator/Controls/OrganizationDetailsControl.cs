using System;
using Administrator.Data;
using Administrator.Frames;
using Administrator.Objects;
using DevExpress.XtraEditors;
using DevExpress.XtraEditors.Controls;

namespace Administrator.Controls
{
    public partial class OrganizationDetailsControl : XtraUserControl
    {
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

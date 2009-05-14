using System;
using System.Windows.Forms;
using Administrator.Data;
using Administrator.EventArgsReferences;

namespace Administrator.Frames
{
    public partial class OrganizationDetailsFrame : BaseFrame
    {
        public OrganizationDetailsFrame()
        {
            InitializeComponent();
        }

        public OrganizationList Organization
        {
            get
            {
                return organizationDetailsControl.Organization;
            }
            set { organizationDetailsControl.Organization = value; }
        }

        public bool IsNewOrganization { get; set; }

        private void saveButton_Click(object sender, EventArgs e)
        {
            if (!ValidateChildren()) return;

            DialogResult = DialogResult.OK;
            Close();
        }

        private void OrganizationDetailsFrame_Shown(object sender, EventArgs e)
        {
            organizationDetailsControl.ScopeOfActitvityList = Program.CurrentDataContext.ScopesOfActivity();
        }

        private void organizationDetailsControl_OrganizationExistanceCheckNeeded(object sender, OrganizationExistanceCheckNeededEventArgs e)
        {
            if(!IsNewOrganization) return;

            var org = Program.CurrentDataContext.GetOrganizationByName(e.Organization.Name, e.Organization.ShortName);

            e.Exists = org != null;
        }
    }
}
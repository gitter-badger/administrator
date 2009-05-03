using System;
using Administrator.Controls;

namespace Administrator.Frames
{
    public partial class OrganizationPanel : ChildFrame
    {
        public OrganizationPanel()
        {
            InitializeComponent();
        }

        private void organizationListControl_OrganizationAdded(object sender, OrganizationUpdatedEventArgs e)
        {
            Program.CurrentDataContext.UpdateOrInsertOrganization(e.Organization);
        }

        private new void Refresh()
        {
            organizationListControl.ReloadData();
        }

        private void OrganizationPanel_Shown(object sender, EventArgs e)
        {
            organizationListControl.DataSource = Program.CurrentDataContext.GetOrganizationQuerry();
        }

        private void organizationListControl_MovedToBlackList(object sender, EventArgsReferences.MovedToBlackListEventArgs e)
        {
            Program.CurrentDataContext.MoveToBlackList(e.BadEntityId,e.Reason);
        }

        private void organizationListControl_MovedFromBlackList(object sender, EventArgsReferences.MovedFromBlackListEventArgs e)
        {
            Program.CurrentDataContext.MoveFromBlackList(e.BadEntityId);
        }
    }
}
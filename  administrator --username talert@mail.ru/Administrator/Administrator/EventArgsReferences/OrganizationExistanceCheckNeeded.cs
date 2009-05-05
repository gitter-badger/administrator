using System;
using Administrator.Data;

namespace Administrator.EventArgsReferences
{
    public delegate void OrganizationExistanceCheckNeededEventHandler(
        object sender, OrganizationExistanceCheckNeededEventArgs e);

    public class OrganizationExistanceCheckNeededEventArgs :EventArgs
    {
        public Organization Organization { get; private set; }
        public bool Exists { get; set; }

        public OrganizationExistanceCheckNeededEventArgs(Organization organization)
        {
            Organization = organization;
        }
    }
}

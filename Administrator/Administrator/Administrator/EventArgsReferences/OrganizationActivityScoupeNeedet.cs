using System;

namespace Administrator.EventArgsReferences
{
    public class OrganizationActivityScoupeNeedetEventArgs : EventArgs
    {
        public OrganizationActivityScoupeNeedetEventArgs(object[] scopeOfActivity)
        {
            ScopeOfActivity = scopeOfActivity;
        }

        public object[] ScopeOfActivity { get; private set; }
    }

    public delegate void OrganizationActivityScoupeNeedetEventHandler(object sender, OrganizationActivityScoupeNeedetEventArgs e);
}

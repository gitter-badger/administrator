using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALProjects.Core.Lookups
{
    [Flags]
    public enum Rights
    {
        None = 0,
        ReadContent =1,
        AddContent = 2,
        ApproveContent =4,
        EditContent = 8,
        ConfidentialView = 16,
        AssignRights = 32,
        All = 255
    }

    public enum Roles
    {
        None = 0,
        Administrator =1,
        User = 2,
        Guest =3
    }
}

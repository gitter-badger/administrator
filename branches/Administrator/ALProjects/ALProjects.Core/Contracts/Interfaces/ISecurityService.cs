using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Lookups;

namespace ALProjects.Core.Contracts.Interfaces
{
    public interface ISecurityService
    {
        Boolean TryLogin(String login, String password);
        void Logoff();
        Boolean IsUserAuthenticated();
        Boolean IsUserHasRights(Rights rights);
        Boolean IsUserInRole(Roles role);
    }
}

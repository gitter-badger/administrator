using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Core.Objects.Security;

namespace ALProjects.Data.Common.Interfaces
{
    public interface ISecurityProvider
    {
        Int32 GetUserId(String login, String password);
        LoginContext GetLoginContext(Int32 userID);
    }
}

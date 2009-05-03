using System;
using System.Linq;
using ALProjects.Core.Lookups;
using ALProjects.Core.Objects;
using ALProjects.Core.Objects.Security;
using ALProjects.Data.Common.Interfaces;
using ALProjects.Data.DataAccessLevel.DALObjects;
using Settings=ALProjects.Core.Config.Settings;

namespace ALProjects.Data.DataAccessLevel.Providers
{
    public class SQLSecurityProvider : ISecurityProvider
    {
        #region ISecurityProvider Members

        public Int32 GetUserId(String login, String password)
        {
            var db = new Security(Settings.Default.ConnectionString);

            scr_user user = (from u in db.scr_users
                             where u.Login == login
                             select u).FirstOrDefault();
            if (user == null)
            {
                return 0;
            }
            if (user.Password.Equals(password, StringComparison.InvariantCultureIgnoreCase))
            {
                return user.UserId;
            }
            return 0;
        }

        public LoginContext GetLoginContext(Int32 userID)
        {
            var db = new Security(Settings.Default.ConnectionString);

            var userInfo = (from info in db.cmn_user_infos
                            join login in db.scr_users on info.UserId equals login.UserId
                            where info.UserId == userID
                            select new {info, login.Login}).FirstOrDefault();
            if (userInfo == null)
            {
                return null;
            }
            scr_role userRole = (from role in db.scr_roles
                                 where role.Id == userInfo.info.Role
                                 select role).SingleOrDefault();
            if (userRole == null)
            {
                return null;
            }

            var uInfo = new UserInfo
                (
                userInfo.info.UserId,
                userInfo.info.FirstName,
                userInfo.info.LastName,
                userInfo.info.Language == null ? Languages.Russian : (Languages) userInfo.info.Language,
                userInfo.info.BirthDate ?? new DateTime(),
                userInfo.info.City.ToString() ?? String.Empty,
                userInfo.info.Addres ?? String.Empty,
                userInfo.info.Phone ?? String.Empty,
                userInfo.info.Email,
                userInfo.info.ICQ.ToString() ?? String.Empty,
                userInfo.info.Site ?? String.Empty);
            var context = new LoginContext(
                uInfo,
                (Roles) Enum.Parse(typeof (Roles), userRole.Role),
                (Rights) userRole.Rights,
                userInfo.Login);

            return context;
        }

        #endregion
    }
}
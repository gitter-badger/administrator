using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Web.Configuration;
using System.Reflection;
using log4net;


namespace ALProjects.Core.Modules
{
    public static class ModuleManager
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(ModuleManager));

        private static readonly List<Object> modules = new List<object>();

        #region public methods
        public static void LoadModules()
        {
           log.Info("Start load modules.");
           log.Info("Modules has been succesefully loaded.");
        }
        #endregion

        #region private methods

        #endregion
    }
}

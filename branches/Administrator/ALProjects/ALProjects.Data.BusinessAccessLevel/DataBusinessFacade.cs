using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using ALProjects.Data.Common;
using ALProjects.Data.Common.Interfaces;

namespace ALProjects.Data.BusinessAccessLevel
{
    [System.Diagnostics.DebuggerStepThrough]
    public class DataBusinessFacade
    {
        #region singlation
        private static readonly DataBusinessFacade _current = new DataBusinessFacade();
        public static DataBusinessFacade Instance
        {
            get { return _current; }
        }
        static DataBusinessFacade() { }
        private DataBusinessFacade() { }
        #endregion

        #region public prorerties
        public ISecurityProvider SecurityProvider
        {
            get { return DataProviderFactory.Instance.SecurityProvider; }
        }
        #endregion
    }
}

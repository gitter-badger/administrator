using System;
using System.Collections.Generic;
using ALProjects.Core.Config;
using ALProjects.Data.Common.Interfaces;
using log4net;

namespace ALProjects.Data.Common
{
    //[System.Diagnostics.DebuggerStepThrough]
    public class DataProviderFactory
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(DataProviderFactory));


        #region singlation

        private static readonly DataProviderFactory _current = new DataProviderFactory();

        private DataProviderFactory()
        {
        }

        public static DataProviderFactory Instance
        {
            get { return _current; }
        }

        #endregion

        #region members

        private readonly Dictionary<Type, object> _services = new Dictionary<Type, object>();

        #endregion

        public ISecurityProvider SecurityProvider
        {
            get
            {
                if (_services.ContainsKey(typeof(ISecurityProvider)))
                {
                    return _services[typeof(ISecurityProvider)] as ISecurityProvider;
                }
                String assemblyName = Settings.Default.DataAccessLevelAssembly;
                String providerName = Settings.Default.SecurityDataProvider;


                ISecurityProvider service = Activator.CreateInstance(assemblyName, providerName).Unwrap() as ISecurityProvider;

                _services.Add(typeof(ISecurityProvider), service);
       
                if (service == null)
                {
                    log.ErrorFormat("Can't load security provider [{0}] from assembly[{1}].", providerName, assemblyName);
                }
                return service;
            }
        }
    }
}
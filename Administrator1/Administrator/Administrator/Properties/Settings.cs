using System;
using System.Configuration;
using log4net;

namespace Administrator.Properties
{
    internal partial class Settings
    {
        private static readonly ILog log = LogManager.GetLogger(typeof(Settings));

        public override void Upgrade()
        {
            try
            {
                foreach (SettingsProperty property in Properties)
                {
                    var prevVersion = GetPreviousVersion(property.Name);

                    var curVersion = this[property.Name];

                    if (prevVersion != null && curVersion != property.DefaultValue)
                    {
                        this[property.Name] = prevVersion;
                    }
                }

                Save();
            }
            catch (Exception ex)
            {
                log.Error(ex);
                Reload();
            }
        }
    }
}
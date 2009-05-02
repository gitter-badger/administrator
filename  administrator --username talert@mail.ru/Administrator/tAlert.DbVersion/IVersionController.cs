using System;

namespace tAlert.DbVersion
{
    public interface IVersionController
    {
        Version GetDBVersion { get; }
        Boolean NeedToBeUpdate();
        bool StartUpdateIfNeedIt();
        bool StartUpdateIfNeedIt(Version finalVersion);
    }
}
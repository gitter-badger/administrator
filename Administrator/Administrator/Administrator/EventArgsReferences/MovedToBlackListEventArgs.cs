using System;

namespace Administrator.EventArgsReferences
{
    public delegate void MovedToBlackListEventHandler(object sender, MovedToBlackListEventArgs e);
    public delegate void MovedFromBlackListEventHandler(object sender, MovedFromBlackListEventArgs e);

    public class MovedToBlackListEventArgs : EventArgs
    {
        public Guid BadEntityId { get; private set; }
        public string Reason { get; private set; }

        public MovedToBlackListEventArgs(Guid badEntityID, string reason)
        {
            BadEntityId = badEntityID;
            Reason = reason;
        }
    }

    public class MovedFromBlackListEventArgs : EventArgs
    {
        public Guid BadEntityId { get; private set; }

        public MovedFromBlackListEventArgs(Guid badEntityID)
        {
            BadEntityId = badEntityID;
        }
    }
}

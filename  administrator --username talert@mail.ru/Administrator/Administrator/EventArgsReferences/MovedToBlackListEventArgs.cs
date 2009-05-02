using System;

namespace Administrator.EventArgsReferences
{
    public delegate void MovedToBlackListEventHandler(object sender, MovedToBlackListEventArgs e);

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
}

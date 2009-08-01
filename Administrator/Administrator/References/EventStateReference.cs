using System.Collections.Generic;

namespace Administrator.References
{
    public class EventStateReference
    {
        private static readonly ReferenceBase<EventStates> referenceBase = new ReferenceBase<EventStates>();

        static EventStateReference()
        {
            referenceBase.References.Add(EventStates.Open, "Открытое");
            referenceBase.References.Add(EventStates.Close, "Завершённое");
            referenceBase.References.Add(EventStates.Refuse, "Отказ");

        }

        public static EventStates GetStateByReference(string reference)
        {
            return referenceBase.GetTypeByReference(reference);
        }

        public static List<string> GetEventStateReferences()
        {
            return referenceBase.GetReferences();
        }

        public static List<string> GetEventStateReferences(List<EventStates> ens)
        {
            return referenceBase.GetReferences(ens);
        }

        public static string GetEventStateReference(EventStates en)
        {
            return referenceBase.GetReference(en);
        }

    }
}

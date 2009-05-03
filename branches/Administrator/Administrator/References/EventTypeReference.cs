using System.Collections.Generic;

namespace Administrator.References
{
    internal static class EventTypeReference 
    {
        private static readonly ReferenceBase<EventTypes> referenceBase = new ReferenceBase<EventTypes>();

        static EventTypeReference() 
        {
            referenceBase.References.Add(EventTypes.Unknown, "Неизвестно");
            referenceBase.References.Add(EventTypes.Conference, "Конференция");
            referenceBase.References.Add(EventTypes.Residence, "Проживание");
            referenceBase.References.Add(EventTypes.Seminar, "Семинар");
            referenceBase.References.Add(EventTypes.Training, "Тренинг");
            referenceBase.References.Add(EventTypes.Banquet, "Банкет");
            referenceBase.References.Add(EventTypes.Another, "Другое");
        }

        public static EventTypes GetTypeByReference(string reference)
        {
            return referenceBase.GetTypeByReference(reference);
        }
        

        public static List<string> GetEventReferences()
        {
            return referenceBase.GetReferences();
        }

        public static List<string> GetEventReferences(List<EventTypes> ens)
        {
            return referenceBase.GetReferences(ens);
        }

        public static string GetEventReference(EventTypes en)
        {
            return referenceBase.GetReference(en);
        }

    }
}

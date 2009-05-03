using System.Collections.Generic;

namespace Administrator.References
{
    internal class PlaceReference : ReferenceBase<PlaceTypes>
    {
        private static readonly PlaceReference instance = new PlaceReference();

        private PlaceReference() 
        {
            references.Add(PlaceTypes.ConferenceRoom, "Залы");
            references.Add(PlaceTypes.HotelRoom, "Гостиница");
            references.Add(PlaceTypes.Another, "Другие услуги");
        }

        public static List<string> GetPlaceReferences(List<PlaceTypes> ens)
        {
            return instance.GetReferences(ens);
        }

        public static string GetPlaceReference(PlaceTypes en)
        {
            return instance.GetReference(en);
        }
    }
}

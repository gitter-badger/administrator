using System;
using System.Collections.Generic;

namespace Administrator.References
{
    internal class ReferenceBase<TEnum> 
    {
        protected readonly Dictionary<TEnum,string> references = new Dictionary<TEnum, string>();

        public ReferenceBase()
        {
            if(!typeof(TEnum).IsEnum)
            {
                throw new TypeInitializationException(typeof(TEnum).ToString(),null);
            }
        }

        public Dictionary<TEnum, string> References
        {
            get { return references; }
        }

        public TEnum GetTypeByReference(string reference)
        {
            TEnum result = default(TEnum);

            foreach (var refer in references)
            {
                if (refer.Value == reference)
                {
                    result = refer.Key;
                    break;
                }
            }

            return result;
        }

        public List<string> GetReferences()
        {
            List<string> result = new List<string>();

            foreach (KeyValuePair<TEnum, string> pair in references)
            {
                result.Add(pair.Value);
            }

            return result;
        }

        public List<string> GetReferences(List<TEnum> ens)
        {
            List<string> result = new List<string>();

            foreach (TEnum en in ens)
            {
                result.Add(GetReference(en));
            }

            return result;
        }

        public string GetReference(TEnum en)
        {
            if(references.ContainsKey(en))
            {
                return references[en];
            }

            return string.Empty;
        }
    }
}

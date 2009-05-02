using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace ALProjects.Core.Exceptions
{
    [global::System.Serializable]
    public class ConfigurationErrorException : Exception
    {
        public ConfigurationErrorException() { }
        public ConfigurationErrorException(string message) : base(message) { }
        public ConfigurationErrorException(string message, Exception inner) : base(message, inner) { }
        protected ConfigurationErrorException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context)
            : base(info, context) { }
    }
}

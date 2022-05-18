using System;
using System.Runtime.Serialization;

namespace Videojatekok
{
    [Serializable]
    public class AdrenalinException : Exception
    {
        public AdrenalinException()
        {
        }

        public AdrenalinException(string message) : base(message)
        {
        }

        public AdrenalinException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected AdrenalinException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
using System;
using System.Runtime.Serialization;

namespace Videojatekok
{
    [Serializable]
    public class TipusException : Exception
    {
        public TipusException()
        {
        }

        public TipusException(string message) : base(message)
        {
        }

        public TipusException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected TipusException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
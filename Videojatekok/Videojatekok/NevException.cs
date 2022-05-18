using System;
using System.Runtime.Serialization;

namespace Videojatekok
{
    [Serializable]
    public class NevException : Exception
    {
        public NevException()
        {
        }

        public NevException(string message) : base(message)
        {
        }

        public NevException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NevException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
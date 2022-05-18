using System;
using System.Runtime.Serialization;

namespace Videojatekok
{
    [Serializable]
    public class NothingFoundException : Exception
    {
        public NothingFoundException()
        {
        }

        public NothingFoundException(string message) : base(message)
        {
        }

        public NothingFoundException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NothingFoundException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
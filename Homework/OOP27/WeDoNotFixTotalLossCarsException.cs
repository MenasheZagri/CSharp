using System;
using System.Runtime.Serialization;

namespace ConsoleApp19
{
    [Serializable]
    internal class WeDoNotFixTotalLossCarsException : Exception
    {
        public WeDoNotFixTotalLossCarsException()
        {
        }

        public WeDoNotFixTotalLossCarsException(string message) : base(message)
        {
        }

        public WeDoNotFixTotalLossCarsException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WeDoNotFixTotalLossCarsException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
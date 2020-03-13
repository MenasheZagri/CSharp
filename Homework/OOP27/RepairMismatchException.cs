using System;
using System.Runtime.Serialization;

namespace ConsoleApp19
{
    [Serializable]
    internal class RepairMismatchException : Exception
    {
        private Car car;

        public RepairMismatchException()
        {
        }

        public RepairMismatchException(Car car)
        {
            this.car = car;
        }

        public RepairMismatchException(string message) : base(message)
        {
        }

        public RepairMismatchException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected RepairMismatchException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
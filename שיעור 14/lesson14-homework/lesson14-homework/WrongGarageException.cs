using System;
using System.Runtime.Serialization;

namespace lesson14_homework
{
    [Serializable]
    internal class WrongGarageException : Exception
    {
        public WrongGarageException()
        {
        }

        public WrongGarageException(string message) : base(message)
        {
        }

        public WrongGarageException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected WrongGarageException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
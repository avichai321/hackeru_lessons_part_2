using System;
using System.Runtime.Serialization;

namespace lesson14___class
{
    [Serializable]
    internal class DishNotValidException : Exception
    {
        public DishNotValidException()
        {
        }

        public DishNotValidException(string message) : base(message)
        {
        }

        public DishNotValidException(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected DishNotValidException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
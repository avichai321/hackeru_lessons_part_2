using System;
using System.Runtime.Serialization;

namespace lesson14___class
{
    [Serializable]
    internal class PitaOutOfRangeExecption : Exception
    {
        public PitaOutOfRangeExecption()
        {
        }

        public PitaOutOfRangeExecption(string message) : base(message)
        {
            Console.WriteLine("dsgbds");
        }

        public PitaOutOfRangeExecption(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected PitaOutOfRangeExecption(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
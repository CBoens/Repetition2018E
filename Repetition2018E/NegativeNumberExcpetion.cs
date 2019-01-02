using System;
using System.Runtime.Serialization;

namespace Repetition2018E
{
    [Serializable]
    public  class NegativeNumberExcpetion : Exception
    {
        // Lav din egen class NegativeNumberException
        public NegativeNumberExcpetion()
        {
        }

        public NegativeNumberExcpetion(string message) : base(message)
        {
        }

        public NegativeNumberExcpetion(string message, Exception innerException) : base(message, innerException)
        {
        }

        protected NegativeNumberExcpetion(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}
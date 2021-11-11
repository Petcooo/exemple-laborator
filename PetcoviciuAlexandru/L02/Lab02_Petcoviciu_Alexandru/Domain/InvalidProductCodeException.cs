using System;
using System.Runtime.Serialization;


namespace Lab02_Petcoviciu_Alexandru.Domain
{
    [Serializable]
    internal class InvalidProductCodeException : Exception
    {
        public InvalidProductCodeException()
        {
        }

        public InvalidProductCodeException(string? message) : base(message)
        {
        }

        public InvalidProductCodeException(string? message, Exception? innerException) : base(message, innerException)
        {
        }

        protected InvalidProductCodeException(SerializationInfo info, StreamingContext context) : base(info, context)
        {
        }
    }
}

using System;

namespace Model.Exceptions
{
    [Serializable]
    public class UnexpectedEnumValueException : Exception
    {
        public UnexpectedEnumValueException() { }
        public UnexpectedEnumValueException(string message) : base(message) { }
        public UnexpectedEnumValueException(string message, Exception inner) : base(message, inner) { }
        protected UnexpectedEnumValueException(
          System.Runtime.Serialization.SerializationInfo info,
          System.Runtime.Serialization.StreamingContext context) : base(info, context) { }
    }
}

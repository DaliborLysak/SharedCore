using System;

namespace Core.Exceptions
{
    public class EmptyCallInProviderException : Exception
    {
        public EmptyCallInProviderException(string message)
            : this(message, null)
        { }

        public EmptyCallInProviderException(string message, Exception innerException)
            : base($"[Core] Empty call in provider: " + message, innerException)
        { }
    }
}

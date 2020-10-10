using System;
using System.Collections.Generic;
using System.Text;

namespace UserRegistrationUC
{
    public class UserRegistrationCustomException : Exception
    {
        public enum ExceptionType
        {
            INVALID_INPUT,NULL_EXCEPTION
        }
        ExceptionType type;
        public UserRegistrationCustomException(ExceptionType type, string message) : base(message)
        {
            this.type = type;
        }
    }
}

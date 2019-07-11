using System;
using System.Collections.Generic;
using System.Runtime.Serialization;
using System.Text;

namespace Telephony.ExceptionMessages
{
    public class InvalidPhoneNumberException : Exception
    {
        private const string EXC_MESSAGE = "Invalid number!";

        public InvalidPhoneNumberException()
            : base(EXC_MESSAGE)
        {
        }

        public InvalidPhoneNumberException(string message)
            : base(message)
        {
        }
    }
}

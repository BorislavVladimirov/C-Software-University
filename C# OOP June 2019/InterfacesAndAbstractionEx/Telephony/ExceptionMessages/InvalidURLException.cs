using System;
using System.Collections.Generic;
using System.Text;

namespace Telephony.ExceptionMessages
{
    public class InvalidURLException : Exception
    {
        private const string EXC_MESSAGE = "Invalid URL!";

        public InvalidURLException()
            : base(EXC_MESSAGE)
        {

        }
        public InvalidURLException(string message)
            : base(message)
        {
        }
    }
}

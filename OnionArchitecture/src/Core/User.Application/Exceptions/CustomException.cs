using System;
using System.Collections.Generic;
using System.Text;

namespace User.Application.Exceptions
{
    public class CustomException : Exception
    {
        public CustomException() : base(" Error Occured ")
        {

        }

        public CustomException(string Message) : base(Message)
        {

        }

        public CustomException(Exception exception) : this(exception.Message)
        {

        }
    }
}

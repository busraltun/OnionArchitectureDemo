using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Application.Exceptions
{
    public class ValidationException : Exception
    {
        public ValidationException(): this("Validation error occured") //hiçbir parametre gelmiyorsa
        {
                
        }
        public ValidationException(string Message) : base(Message)
        {

        }
        public ValidationException(Exception ex) : this(ex.Message)
        {

        }
    }
}

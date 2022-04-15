using System;
using System.Collections.Generic;
using System.Text;

namespace User.Application.Parameters
{
    public class RequestParameter
    {
        public int UserAge { get; set; }
        public RequestParameter(int userAge)
        {
            UserAge = userAge;
        }
    }
}

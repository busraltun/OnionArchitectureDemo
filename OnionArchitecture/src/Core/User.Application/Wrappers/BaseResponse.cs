using System;
using System.Collections.Generic;
using System.Text;

namespace User.Application.Wrappers
{
    public class BaseResponse
    {
        public int Id { get; set; }
        public bool Success { get; set; }
        public string Message { get; set; }

    }
}

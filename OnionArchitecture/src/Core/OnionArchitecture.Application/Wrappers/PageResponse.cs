using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Application.Wrappers
{
    public class PageResponse<T> : ServiceResponse
    {
        public int PageNumber { get; set; }
        public int PageSize { get; set; }

        public PageResponse(T value) : base(value)
        {

        }
        public PageResponse()
        {
            PageNumber = 1;
            PageSize = 10;
        }
    }
}

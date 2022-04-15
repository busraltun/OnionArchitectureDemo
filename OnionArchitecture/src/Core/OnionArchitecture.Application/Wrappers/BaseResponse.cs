using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Application.Wrappers
{
    /// <summary>
    /// servisimizden geriye her türlü bu obje dönsün
    /// </summary>
    public  class BaseResponse
    {
        public Guid Id { get; set; }
        public string Message { get; set; }
        public bool Success { get; set; }
    }
}

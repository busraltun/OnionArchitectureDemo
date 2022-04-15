using System;
using System.Collections.Generic;
using System.Text;

namespace OnionArchitecture.Domain.Common
{
    public abstract class BaseEntity
    {
        public Guid Id { get; set; }
        public DateTime CreatedDate { get; set; }
    }
}

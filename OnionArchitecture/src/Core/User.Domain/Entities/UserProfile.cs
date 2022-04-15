using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Common;

namespace User.Domain.Entities
{
    public class UserProfile : BaseEntity
    {
        public string FirstName { get; set; }
        public string LastName { get; set; }
        public string Address { get; set; }
        public virtual Users Users { get; set; }

    }
}

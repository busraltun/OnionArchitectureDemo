using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Common;

namespace User.Domain.Entities
{
    public class Users : BaseEntity
    {
        public string UserName { get; set; }
        public string Email { get; set; }
        public string Password { get; set; }
        public virtual UserProfile UserProfile { get; set; }

    }
}

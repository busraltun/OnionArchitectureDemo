using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Entities;

namespace User.Application.Interfaces.Repositories
{
    internal interface IUserProfileRepository : IRepository<UserProfile> 
    {
    }
}

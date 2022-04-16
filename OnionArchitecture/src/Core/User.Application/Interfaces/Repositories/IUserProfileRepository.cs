using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Entities;

namespace User.Application.Interfaces.Repositories
{
    public interface IUserProfileRepository : IRepository<UserProfile> 
    {
    }
}

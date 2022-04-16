using System;
using System.Collections.Generic;
using System.Text;
using User.Application.Interfaces.Repositories;
using User.Domain.Entities;
using User.Persistence.Context;

namespace User.Persistence.Repositories
{
    public class UsersRepository : Repository<Users>, IUsersRepository
    {
        public UsersRepository(ApplicationContext applicationContext) : base(applicationContext)
        {
        }
    }
}

using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using User.Domain.Entities;

namespace User.Application.Interfaces.Context
{
    public interface IApplicationContext
    {
        DbSet<Users> Users { get; set; }
        DbSet<UserProfile> UserProfiles { get; set; }
    }
}

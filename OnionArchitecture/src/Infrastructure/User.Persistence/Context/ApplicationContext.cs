using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Reflection;
using System.Text;
using User.Application.Interfaces.Context;
using User.Domain.Entities;

namespace User.Persistence.Context
{
    public class ApplicationContext : DbContext, IApplicationContext
    {
        public ApplicationContext(DbContextOptions<ApplicationContext> options) : base(options)
        {

        }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //Configuration ları haberdar ediyorum
            modelBuilder.ApplyConfigurationsFromAssembly(Assembly.GetExecutingAssembly());

            /*
              Tek bir tane configuration dosyasını çalıştırmak için;
             modelBuilder.ApplyConfigurationsFromAssembly(new UsersConfiguration());
             */
            base.OnModelCreating(modelBuilder);
        }
        public DbSet<Users> Users { get; set; }
        public DbSet<UserProfile> UserProfiles { get; set; }
    }
}

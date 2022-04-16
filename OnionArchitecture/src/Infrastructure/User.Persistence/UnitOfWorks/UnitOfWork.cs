using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Application.Interfaces.Repositories;
using User.Application.Interfaces.UnitOfWorks;
using User.Persistence.Context;

namespace User.Persistence.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly ApplicationContext _applicationContext;
        public UnitOfWork(ApplicationContext applicationContext)
        {
            _applicationContext = applicationContext;
        }
        public void Commit()
        {
            _applicationContext.SaveChanges();
        }

        public async Task CommitAsync()
        {
            await _applicationContext.SaveChangesAsync();
        }

    }
}

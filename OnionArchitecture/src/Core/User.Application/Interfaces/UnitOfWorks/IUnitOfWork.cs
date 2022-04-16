using Microsoft.EntityFrameworkCore.Storage;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Application.Interfaces.Repositories;

namespace User.Application.Interfaces.UnitOfWorks
{
    public interface IUnitOfWork 
    {
        //Task<IDbContextTransaction> BeginTransactionAsync();
        //public IUsersRepository UsersRepository { get; }

        Task CommitAsync();
        void Commit();
    }
}

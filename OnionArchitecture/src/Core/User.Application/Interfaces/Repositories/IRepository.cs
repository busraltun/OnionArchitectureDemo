using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;
using User.Domain.Common;

namespace User.Application.Interfaces.Repositories
{
    public interface IRepository<T> where T : BaseEntity, new()
    {
        Task<List<T>> GetAsync();
        Task<T> GetByIdAsync(int Id);
        Task<T> AddAsync(T entity);
        Task<T> UpdateAsync(T entity);
        Task DeleteAsync(T entity);
        Task RemoveAsync(T entity);

        T GetById(int Id);
        IEnumerable<T> GetAll();



    }
}

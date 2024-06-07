using Domain.Entities.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Appication.Repositories
{
    public interface IWriteRepository<T> :IRepository<T> where T : BaseEntity
    {
        Task<bool> AddAsync(T model);
        Task<bool> AddRangeAsync(List<T> datas);
        bool Update(T model);
        bool RemoveRangeAsync(List<T> datas);
        bool Remove(T model);
        Task<bool> RemoveAsync(string id);

        Task<int> SaveAsync();
    }
}

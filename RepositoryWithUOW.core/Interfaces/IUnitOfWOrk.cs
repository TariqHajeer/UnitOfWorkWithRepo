using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOW.core.Interfaces
{
    public interface IUnitOfWOrk
    {
        IRepository<TEntity> Repository<TEntity>() where TEntity : class;
        Task Add<TEntity>(TEntity entity) where TEntity : class;
        Task SaveChange();

    }
}

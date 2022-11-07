using Microsoft.EntityFrameworkCore;
using RepositoryWithUOW.core.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace RepositoryWithUOW.EF.Repository
{
    public class Repository<T> : IRepository<T> where T : class
    {
        private readonly ApplicationDBContext _dbContext;
        private readonly IQueryable<T> _query; 
        public Repository(ApplicationDBContext dbContext)
        {
            _dbContext = dbContext;
            _query = _dbContext.Set<T>().AsQueryable();

        }
        public async Task AddAsync(T entity)
        {
            await _dbContext.AddAsync(entity);
        }

        public async Task<IEnumerable<T>> GetAll()
        {
            return await _query.ToListAsync();
        }
    }
}

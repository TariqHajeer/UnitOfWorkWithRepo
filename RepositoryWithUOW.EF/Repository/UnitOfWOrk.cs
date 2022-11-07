using RepositoryWithUOW.core.Interfaces;
    
namespace RepositoryWithUOW.EF.Repository
{
    public class UnitOfWOrk : IUnitOfWOrk
    {

        private readonly ApplicationDBContext _context;
        private readonly Dictionary<string, object> _repositories;
        public UnitOfWOrk(ApplicationDBContext applicationDBContext = null)
        {
            this._context = applicationDBContext;
            _repositories = new Dictionary<string, object>();
        }
        public IRepository<TEntity> Repository<TEntity>() where TEntity : class
        {
            var type = typeof(TEntity).Name;
            if (!_repositories.ContainsKey(type))
            {
                //var repositoryType = typeof(Repository<TEntity>);
                var repositoryInstance = new Repository<TEntity>(_context);
                //var repositoryInstance = Activator.CreateInstance(repositoryType.MakeGenericType());
                _repositories.Add(type, repositoryInstance);
            }
            return (Repository<TEntity>)_repositories[type];
        }
        public async Task Add<TEntity>(TEntity entity) where TEntity:class
        {
            await this.Repository<TEntity>().AddAsync(entity);
        }

        public async Task SaveChange()
        {
            await _context.SaveChangesAsync();
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WordPressNetCore.Repositories
{
    public interface IRepository<TEntity>
    {
        public void Insert(TEntity user);
        public List<TEntity> GetAll();
        public TEntity GetById(int id);
        public TEntity Update(TEntity user);
        public bool Delete(int id);
    }
}

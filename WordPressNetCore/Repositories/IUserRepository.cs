using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressNetCore.Models;

namespace WordPressNetCore.Repositories
{
    public interface IUserRepository
    {
        public void Insert(User user);
        public List<User> GetAll();
        public User GetById(int id);
        public User Update(User user);
        public bool Delete(int id);
    }
}

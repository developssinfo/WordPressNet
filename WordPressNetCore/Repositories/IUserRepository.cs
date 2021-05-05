using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressNetCore.Models;

namespace WordPressNetCore.Repositories
{
    public interface IUserRepository : IRepository<User>
    {
        public List<User> GetUsersByName(string name);
    }
}

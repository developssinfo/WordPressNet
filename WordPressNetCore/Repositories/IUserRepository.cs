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
    }
}

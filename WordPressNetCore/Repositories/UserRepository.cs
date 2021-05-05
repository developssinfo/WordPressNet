using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressNetCore.Models;

namespace WordPressNetCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        IApplicationDbContext dbContext;
        public UserRepository(IApplicationDbContext applicationDbContext)
        {
            this.dbContext = applicationDbContext;
        }

        public void Insert(User user)
        {
            dbContext.User.Add(user);
            dbContext.Instance.SaveChanges();
        }
    }
}

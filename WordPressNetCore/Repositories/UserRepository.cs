using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressNetCore.Models;
using Microsoft.EntityFrameworkCore;

namespace WordPressNetCore.Repositories
{
    public class UserRepository : IUserRepository
    {
        IApplicationDbContext dbContext;
        public UserRepository(IApplicationDbContext applicationDbContext)
        {
            this.dbContext = applicationDbContext;
        }

        public bool Delete(int id)
        {
            int count = 0;
            var user = dbContext.User.FirstOrDefault(i => i.Id == id);

            if (user != null)
            {
                dbContext.Instance.Entry(user).State = EntityState.Deleted;
                count = dbContext.Instance.SaveChanges();
            }

            return count > 0;
        }

        public List<User> GetAll()
        {
            return dbContext.User.ToList();
        }

        public User GetById(int id)
        {
            return dbContext.User.FirstOrDefault(u => u.Id == id);
        }

        public List<User> GetUsersByName(string name)
        {
            return dbContext.User.Where(u => u.UserName.ToUpper().Contains(name)).ToList();
        }

        public void Insert(User user)
        {
            dbContext.Instance.Add(user);
            dbContext.Instance.SaveChanges();
        }

        public User Update(User user)
        {
            dbContext.Instance.Update(user);
            dbContext.Instance.SaveChanges();

            return dbContext.User.FirstOrDefault(u => u.Id == user.Id);
        }
    }
}

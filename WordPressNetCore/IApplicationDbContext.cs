using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using WordPressNetCore.Models;

namespace WordPressNetCore
{
    public interface IApplicationDbContext
    {
        public DbContext Instance { get; }
        public DbSet<User> User { get; set; }
    }
}

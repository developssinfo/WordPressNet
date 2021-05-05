using Microsoft.EntityFrameworkCore;
using System.Diagnostics.CodeAnalysis;
using WordPressNetCore.Models;

namespace WordPressNetCore
{
    public class ApplicationDbContext : DbContext, IApplicationDbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base (options)
        {

        }

        public DbContext Instance => this;
        public DbSet<User> User { get; set; }
    }
}

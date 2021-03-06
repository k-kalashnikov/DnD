using DnD.Infrastructure.Models;
using Microsoft.EntityFrameworkCore;

namespace DnD.Infrastructure
{
    public class ApplicationDbContext : DbContext
    {
        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public DbSet<UserModel> Users { get; set; }
    }
}

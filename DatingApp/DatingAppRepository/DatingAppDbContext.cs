using DatingAppRepository.DataModels;
using Microsoft.EntityFrameworkCore;

namespace DatingAppRepository
{
    public class DatingAppDbContext : DbContext
    {
        public DatingAppDbContext(DbContextOptions<DatingAppDbContext> options):base(options)
        {
        }

        public DbSet<User> Users { get; set; }
    }
}

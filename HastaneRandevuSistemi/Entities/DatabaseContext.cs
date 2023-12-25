using Microsoft.EntityFrameworkCore;

namespace HastaneRandevuSistemi.Entities
{
    public class DatabaseContext : DbContext
    {
        public DatabaseContext(DbContextOptions options) : base(options)
        {
        }

        public  DbSet<User> Users { get; set; }
        public DbSet<DbDoctor> Doctors { get; set; }
        public DbSet<DbHasta> Hastas { get; set; }
        public DbSet<DbRandevu> Randevus { get; set; }
    }
}

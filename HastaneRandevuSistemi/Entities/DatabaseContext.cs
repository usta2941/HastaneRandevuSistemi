using Microsoft.EntityFrameworkCore;
using System.Security.Cryptography.X509Certificates;


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
        public DbSet<Clinic> clinics { get; set; }


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            

            base.OnModelCreating(modelBuilder);

            

        }
    }
}

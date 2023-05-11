using koishowweb.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace koishowweb
{
    public class DbContextKoi: DbContext
    {

        public DbContextKoi(DbContextOptions<DbContextKoi> options) : base(options)
        {
        }

        public DbSet<Sensor> Sensor { get; set; }
        public DbSet<Temperatures> Temperature { get; set; }
        public DbSet<Vat> Vat { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Vat>().HasKey(x => x.VatId);
        }

        //protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        //{
        //    optionsBuilder.UseSqlServer(optionsBuilder.Con("connectionString"));
        //}

    }
}


using Microsoft.EntityFrameworkCore;

namespace CarDealership.Repository
{
    public class EfCoreDbContext : DbContext
    {
        private string _connectionString = "Server=DESKTOP-SM098C1;Database=cars;Trusted_Connection=True;";
        public EfCoreDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }
        public EfCoreDbContext()
        {

        }
        //public DbSet<ValueEntity> Values { get; set; }
        //public DbSet<ValueHistoryEntity> Histories { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //base.OnModelCreating(modelBuilder);
            //modelBuilder.Entity<ValueEntity>().HasData(new List<ValueEntity>
            //{

              
            //});
            //modelBuilder.Entity<ValueHistoryEntity>().HasData(new List<ValueHistoryEntity>
            //{
               
            //});
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_connectionString);
            base.OnConfiguring(builder);
        }
    }
}

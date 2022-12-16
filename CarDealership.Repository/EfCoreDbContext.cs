
using CarDealership.Repository.Entities;
using CarDealership.Repository.Enums;
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
        public DbSet<CarEntity> Car { get; set; }
        public DbSet<PurchaseEntity> Purchase { get; set; }
        public DbSet<SellerEntity> Seller { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);
            modelBuilder.Entity<CarEntity>().HasData(new List<CarEntity>
            {
                new CarEntity
                {
                    Id = 1,
                    Mark = "BMV",
                    Name = "X3",
                    CreatedYear = 2010,
                    FuelTankSize = 2.1,
                    Type = CarType.Sedan,
                    Price = 100000,
                },
                new CarEntity
                {
                    Id = 2,
                    Mark = "BMV",
                    Name = "X5",
                    CreatedYear = 2012,
                    FuelTankSize = 2.5,
                    Type = CarType.Minivan,
                    Price = 200000
                },
                new CarEntity
                {
                    Id = 3,
                    Mark = "Audi",
                    Name = "A3",
                    CreatedYear = 2013,
                    FuelTankSize = 1.5,
                    Type = CarType.Pickup,
                    Price = 300000
                },
                new CarEntity
                {
                    Id = 4,
                    Mark = "Audi",
                    Name = "A4",
                    CreatedYear = 2014,
                    FuelTankSize = 2.2,
                    Type = CarType.Jeep,
                    Price = 400000
                },
                new CarEntity
                {
                    Id = 5,
                    Mark = "Audi",
                    Name = "A5",
                    CreatedYear = 2015,
                    FuelTankSize = 2.6,
                    Type = CarType.Hatchback,
                    Price = 500000
                },
              
            });

            modelBuilder.Entity<SellerEntity>().HasData(new List<SellerEntity>
            {
                new SellerEntity
                {
                    Id = 1,
                    FirstName = "Pavlo",
                    SecondName = "Somko",
                    City = "Lviv",
                    Bonuses = 0
                },
                new SellerEntity
                {
                    Id = 2,
                    FirstName = "Pavlo",
                    SecondName = "Serdyuk",
                    City = "Lviv",
                    Bonuses = 10
                },
                new SellerEntity
                {
                    Id = 3,
                    FirstName = "Ilya",
                    SecondName = "Lutsyk",
                    City = "Lviv",
                    Bonuses = 5
                },
                new SellerEntity
                {
                    Id = 4,
                    FirstName = "Andrii",
                    SecondName = "Mykulyak",
                    City = "Lviv",
                    Bonuses = 5
                }
            });
        }
        protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {
            builder.UseSqlServer(_connectionString);
            base.OnConfiguring(builder);
        }
    }
}

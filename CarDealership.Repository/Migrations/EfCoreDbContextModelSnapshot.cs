// <auto-generated />
using System;
using CarDealership.Repository;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace CarDealership.Repository.Migrations
{
    [DbContext(typeof(EfCoreDbContext))]
    partial class EfCoreDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.8")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("CarDealership.Repository.Entities.CarEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CreatedYear")
                        .HasColumnType("int");

                    b.Property<double>("FuelTankSize")
                        .HasColumnType("float");

                    b.Property<string>("Mark")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<decimal>("Price")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("Type")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Car");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CreatedYear = 2010,
                            FuelTankSize = 2.1000000000000001,
                            Mark = "BMV",
                            Name = "X3",
                            Price = 0m,
                            Type = 0
                        },
                        new
                        {
                            Id = 2,
                            CreatedYear = 2012,
                            FuelTankSize = 2.5,
                            Mark = "BMV",
                            Name = "X5",
                            Price = 0m,
                            Type = 2
                        },
                        new
                        {
                            Id = 3,
                            CreatedYear = 2013,
                            FuelTankSize = 1.5,
                            Mark = "Audi",
                            Name = "A3",
                            Price = 0m,
                            Type = 4
                        },
                        new
                        {
                            Id = 4,
                            CreatedYear = 2014,
                            FuelTankSize = 2.2000000000000002,
                            Mark = "Audi",
                            Name = "A4",
                            Price = 0m,
                            Type = 5
                        },
                        new
                        {
                            Id = 5,
                            CreatedYear = 2015,
                            FuelTankSize = 2.6000000000000001,
                            Mark = "Audi",
                            Name = "A5",
                            Price = 0m,
                            Type = 1
                        });
                });

            modelBuilder.Entity("CarDealership.Repository.Entities.PurchaseEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("BuyerName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<decimal>("DealPrice")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("PurchaseDate")
                        .HasColumnType("datetime2");

                    b.Property<int>("SellerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Purchase");
                });

            modelBuilder.Entity("CarDealership.Repository.Entities.SellerEntity", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal>("Bonuses")
                        .HasColumnType("decimal(18,2)");

                    b.Property<string>("City")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("SecondName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Seller");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Bonuses = 0m,
                            City = "Lviv",
                            FirstName = "Pavlo",
                            SecondName = "Somko"
                        },
                        new
                        {
                            Id = 2,
                            Bonuses = 10m,
                            City = "Lviv",
                            FirstName = "Pavlo",
                            SecondName = "Serdyuk"
                        },
                        new
                        {
                            Id = 3,
                            Bonuses = 5m,
                            City = "Lviv",
                            FirstName = "Ilya",
                            SecondName = "Lutsyk"
                        },
                        new
                        {
                            Id = 4,
                            Bonuses = 5m,
                            City = "Lviv",
                            FirstName = "Andrii",
                            SecondName = "Mykulyak"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

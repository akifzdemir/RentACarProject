﻿// <auto-generated />
using System;
using DataAccess.Concrete.EntityFramework;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace DataAccess.Migrations
{
    [DbContext(typeof(RentACarContext))]
    partial class RentACarContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.9")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("Core.Entities.Concrete.OperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("OperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Name = "user"
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.User", b =>
                {
                    b.Property<int>("UserId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("UserId"), 1L, 1);

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("FirstName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<byte[]>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<byte[]>("PasswordSalt")
                        .IsRequired()
                        .HasColumnType("varbinary(max)");

                    b.Property<bool>("Status")
                        .HasColumnType("bit");

                    b.HasKey("UserId");

                    b.ToTable("Users");

                    b.HasData(
                        new
                        {
                            UserId = 1,
                            Email = "akif@ozdemir.com",
                            FirstName = "Mehmet Akif",
                            LastName = "Özdemir",
                            PasswordHash = new byte[] { 76, 145, 155, 123, 143, 217, 23, 13, 172, 174, 73, 235, 177, 103, 84, 23, 250, 158, 229, 179, 163, 15, 121, 133, 86, 88, 104, 46, 81, 197, 61, 226, 200, 96, 153, 31, 136, 192, 178, 142, 30, 218, 26, 93, 242, 194, 126, 27, 145, 222, 45, 134, 18, 114, 210, 172, 108, 152, 187, 16, 242, 69, 242, 153 },
                            PasswordSalt = new byte[] { 229, 64, 172, 188, 93, 27, 148, 149, 195, 157, 71, 146, 228, 143, 88, 229, 174, 186, 233, 167, 238, 176, 180, 4, 34, 38, 8, 70, 207, 40, 204, 30, 0, 254, 16, 252, 194, 19, 46, 105, 131, 185, 29, 130, 195, 45, 196, 193, 166, 151, 183, 21, 236, 233, 82, 44, 16, 218, 223, 41, 37, 63, 242, 155, 255, 52, 6, 114, 61, 183, 252, 236, 85, 148, 144, 27, 181, 33, 226, 197, 59, 14, 101, 142, 169, 176, 33, 39, 245, 241, 12, 216, 214, 240, 185, 112, 196, 62, 21, 18, 17, 186, 116, 175, 142, 225, 66, 182, 84, 81, 243, 89, 133, 41, 29, 14, 98, 167, 111, 87, 34, 56, 0, 47, 249, 22, 126, 208 },
                            Status = true
                        });
                });

            modelBuilder.Entity("Core.Entities.Concrete.UserOperationClaim", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("OperationClaimId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("UserOperationClaims");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            OperationClaimId = 1,
                            UserId = 1
                        });
                });

            modelBuilder.Entity("Entitites.Concrete.Brand", b =>
                {
                    b.Property<int>("BrandId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BrandId"), 1L, 1);

                    b.Property<string>("BrandName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("BrandId");

                    b.ToTable("Brands");

                    b.HasData(
                        new
                        {
                            BrandId = 1,
                            BrandName = "BMW"
                        },
                        new
                        {
                            BrandId = 2,
                            BrandName = "Skoda"
                        },
                        new
                        {
                            BrandId = 3,
                            BrandName = "Renault"
                        },
                        new
                        {
                            BrandId = 4,
                            BrandName = "Volkswagen"
                        });
                });

            modelBuilder.Entity("Entitites.Concrete.Car", b =>
                {
                    b.Property<int>("CarId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("CarId"), 1L, 1);

                    b.Property<int>("BrandId")
                        .HasColumnType("int");

                    b.Property<int>("ColorId")
                        .HasColumnType("int");

                    b.Property<int>("DailyPrice")
                        .HasColumnType("int");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<bool>("IsRentable")
                        .HasColumnType("bit");

                    b.Property<int>("ModelYear")
                        .HasColumnType("int");

                    b.Property<int>("OwnerId")
                        .HasColumnType("int");

                    b.HasKey("CarId");

                    b.HasIndex("BrandId");

                    b.HasIndex("ColorId");

                    b.ToTable("Cars");

                    b.HasData(
                        new
                        {
                            CarId = 1,
                            BrandId = 2,
                            ColorId = 3,
                            DailyPrice = 400,
                            Description = "Fabia",
                            IsRentable = true,
                            ModelYear = 2018,
                            OwnerId = 1
                        },
                        new
                        {
                            CarId = 2,
                            BrandId = 4,
                            ColorId = 4,
                            DailyPrice = 500,
                            Description = "Tiguan",
                            IsRentable = true,
                            ModelYear = 2020,
                            OwnerId = 1
                        },
                        new
                        {
                            CarId = 3,
                            BrandId = 3,
                            ColorId = 1,
                            DailyPrice = 300,
                            Description = "Fluence",
                            IsRentable = true,
                            ModelYear = 2018,
                            OwnerId = 1
                        },
                        new
                        {
                            CarId = 4,
                            BrandId = 4,
                            ColorId = 5,
                            DailyPrice = 400,
                            Description = "Golf",
                            IsRentable = true,
                            ModelYear = 2010,
                            OwnerId = 1
                        },
                        new
                        {
                            CarId = 5,
                            BrandId = 1,
                            ColorId = 2,
                            DailyPrice = 800,
                            Description = "X7",
                            IsRentable = true,
                            ModelYear = 2018,
                            OwnerId = 1
                        });
                });

            modelBuilder.Entity("Entitites.Concrete.CarImage", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImagePath")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("CarId");

                    b.ToTable("CarImages");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            CarId = 1,
                            Date = new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7749),
                            ImagePath = "3cffc9b7-e111-4f2e-98bb-70f38a325232.jpg"
                        },
                        new
                        {
                            Id = 2,
                            CarId = 2,
                            Date = new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7760),
                            ImagePath = "2e73e3d1-4add-4b63-8e2d-5fec0188ef5d.jpg"
                        },
                        new
                        {
                            Id = 3,
                            CarId = 3,
                            Date = new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7761),
                            ImagePath = "35676709-24bd-4b90-90df-d737bf8d1159.jpg"
                        },
                        new
                        {
                            Id = 4,
                            CarId = 4,
                            Date = new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7762),
                            ImagePath = "d6448427-0c49-4219-a8bf-625726cd1ad8.jpg"
                        },
                        new
                        {
                            Id = 5,
                            CarId = 5,
                            Date = new DateTime(2022, 9, 21, 18, 2, 20, 413, DateTimeKind.Local).AddTicks(7762),
                            ImagePath = "c694f801-94c7-4217-9bde-f219e91825e7.jpg"
                        });
                });

            modelBuilder.Entity("Entitites.Concrete.Color", b =>
                {
                    b.Property<int>("ColorId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ColorId"), 1L, 1);

                    b.Property<string>("ColorName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ColorId");

                    b.ToTable("Colors");

                    b.HasData(
                        new
                        {
                            ColorId = 1,
                            ColorName = "White"
                        },
                        new
                        {
                            ColorId = 2,
                            ColorName = "Black"
                        },
                        new
                        {
                            ColorId = 3,
                            ColorName = "Orange"
                        },
                        new
                        {
                            ColorId = 4,
                            ColorName = "Red"
                        },
                        new
                        {
                            ColorId = 5,
                            ColorName = "Grey"
                        });
                });

            modelBuilder.Entity("Entitites.Concrete.Rental", b =>
                {
                    b.Property<int>("RentalId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("RentalId"), 1L, 1);

                    b.Property<int>("CarId")
                        .HasColumnType("int");

                    b.Property<DateTime?>("RentDate")
                        .HasColumnType("date");

                    b.Property<DateTime>("ReturnDate")
                        .HasColumnType("date");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("RentalId");

                    b.HasIndex("CarId");

                    b.HasIndex("UserId");

                    b.ToTable("Rentals");
                });

            modelBuilder.Entity("Entitites.Concrete.Car", b =>
                {
                    b.HasOne("Entitites.Concrete.Brand", null)
                        .WithMany()
                        .HasForeignKey("BrandId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Entitites.Concrete.Color", null)
                        .WithMany()
                        .HasForeignKey("ColorId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entitites.Concrete.CarImage", b =>
                {
                    b.HasOne("Entitites.Concrete.Car", null)
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });

            modelBuilder.Entity("Entitites.Concrete.Rental", b =>
                {
                    b.HasOne("Entitites.Concrete.Car", null)
                        .WithMany()
                        .HasForeignKey("CarId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Core.Entities.Concrete.User", null)
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();
                });
#pragma warning restore 612, 618
        }
    }
}

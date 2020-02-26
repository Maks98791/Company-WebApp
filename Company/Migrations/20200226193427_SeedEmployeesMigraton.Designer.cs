﻿// <auto-generated />
using Company.DataAccess;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

namespace Company.Migrations
{
    [DbContext(typeof(AppDbContext))]
    [Migration("20200226193427_SeedEmployeesMigraton")]
    partial class SeedEmployeesMigraton
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "3.1.2")
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("Company.Models.Employee", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<int>("Department")
                        .HasColumnType("int");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.Property<string>("Surname")
                        .IsRequired()
                        .HasColumnType("nvarchar(30)")
                        .HasMaxLength(30);

                    b.HasKey("Id");

                    b.ToTable("Employees");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Department = 1,
                            Email = "adam123@gmail.com",
                            Name = "Adam",
                            Surname = "Jackson"
                        },
                        new
                        {
                            Id = 2,
                            Department = 2,
                            Email = "ann765@gmail.com",
                            Name = "Ann",
                            Surname = "Ornah"
                        },
                        new
                        {
                            Id = 3,
                            Department = 0,
                            Email = "noah7654@gmail.com",
                            Name = "Noah",
                            Surname = "Ming"
                        },
                        new
                        {
                            Id = 4,
                            Department = 1,
                            Email = "steven6543@gmail.com",
                            Name = "Steven",
                            Surname = "Sparrow"
                        },
                        new
                        {
                            Id = 5,
                            Department = 2,
                            Email = "michael5432@gmail.com",
                            Name = "Michael",
                            Surname = "Anthony"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

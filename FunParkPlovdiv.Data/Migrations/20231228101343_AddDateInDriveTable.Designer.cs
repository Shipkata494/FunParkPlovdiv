﻿// <auto-generated />
using System;
using FunParkPlovdiv.Data;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;

#nullable disable

namespace FunParkPlovdiv.Data.Migrations
{
    [DbContext(typeof(FunParkPlovdivDbContext))]
    [Migration("20231228101343_AddDateInDriveTable")]
    partial class AddDateInDriveTable
    {
        /// <inheritdoc />
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "8.0.0")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("FunParkPlovdiv.Data.Models.Administrator", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<string>("PasswordHash")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Username")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Administrator");
                });

            modelBuilder.Entity("FunParkPlovdiv.Data.Models.Drive", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"));

                    b.Property<int>("Courses")
                        .HasColumnType("int");

                    b.Property<DateTime>("Date")
                        .HasColumnType("datetime2");

                    b.Property<Guid?>("UserId")
                        .HasColumnType("uniqueidentifier");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Drive");
                });

            modelBuilder.Entity("FunParkPlovdiv.Data.Models.Prices", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Description")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Title")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<decimal>("Value")
                        .HasPrecision(8, 2)
                        .HasColumnType("decimal(8,2)");

                    b.HasKey("Id");

                    b.ToTable("Prices");

                    b.HasData(
                        new
                        {
                            Id = new Guid("372361ca-eef4-4ebc-bacc-be7dfb0e0391"),
                            Description = "MiniCourse",
                            Title = "10 мин",
                            Value = 25m
                        },
                        new
                        {
                            Id = new Guid("ef9dc987-075d-43ee-88de-243f701f758b"),
                            Description = "BigCourse",
                            Title = "15 мин",
                            Value = 35m
                        },
                        new
                        {
                            Id = new Guid("c4404eae-b97c-485f-89f4-c49b8ca2d94d"),
                            Description = "BirthDay",
                            Title = "1 час",
                            Value = 200m
                        });
                });

            modelBuilder.Entity("FunParkPlovdiv.Data.Models.User", b =>
                {
                    b.Property<Guid>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("uniqueidentifier");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("LastName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("MiddleName")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasMaxLength(50)
                        .HasColumnType("nvarchar(50)");

                    b.HasKey("Id");

                    b.ToTable("Users");
                });

            modelBuilder.Entity("FunParkPlovdiv.Data.Models.Drive", b =>
                {
                    b.HasOne("FunParkPlovdiv.Data.Models.User", null)
                        .WithMany("Drives")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("FunParkPlovdiv.Data.Models.User", b =>
                {
                    b.Navigation("Drives");
                });
#pragma warning restore 612, 618
        }
    }
}
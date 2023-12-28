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
    [Migration("20231228101509_AjustDefaultDateTime")]
    partial class AjustDefaultDateTime
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
                            Id = new Guid("1db856fe-ec7f-4a79-bede-7f42a0bab10a"),
                            Description = "MiniCourse",
                            Title = "10 мин",
                            Value = 25m
                        },
                        new
                        {
                            Id = new Guid("b1e3d403-7b40-4f0e-86ee-4b57558be3d5"),
                            Description = "BigCourse",
                            Title = "15 мин",
                            Value = 35m
                        },
                        new
                        {
                            Id = new Guid("3f20b6ec-0843-4249-95c3-3f9c0c866a09"),
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
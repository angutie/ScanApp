﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using mentor_3;

namespace mentor_3.Migrations
{
    [DbContext(typeof(ScanDatabaseContext))]
    partial class ScanDatabaseContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.3");

            modelBuilder.Entity("mentor_3.Models.PostingScans", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<DateTime>("CreatedTime")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("datetime2")
                        .HasColumnName("Timestamp")
                        .HasDefaultValueSql("getdate()");

                    b.Property<int>("EmployeeId")
                        .HasColumnType("int")
                        .HasColumnName("EmployeeId");

                    b.Property<string>("Location")
                        .HasColumnType("nvarchar(max)")
                        .HasColumnName("Location");

                    b.Property<int>("ScannerId")
                        .HasColumnType("int")
                        .HasColumnName("ScannerId");

                    b.HasKey("ID");

                    b.ToTable("ScanLog");

                    b.HasData(
                        new
                        {
                            ID = 1,
                            CreatedTime = new DateTime(1, 1, 1, 0, 0, 0, 0, DateTimeKind.Unspecified),
                            EmployeeId = 0,
                            ScannerId = 0
                        });
                });
#pragma warning restore 612, 618
        }
    }
}

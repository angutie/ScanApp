using System;
using System.Collections.Generic;
using mentor_3.Models;
using mentor_3.Controllers;
using Microsoft.EntityFrameworkCore;

namespace mentor_3
{
    public class ScanDatabaseContext : DbContext
    {
        public ScanDatabaseContext (DbContextOptions<ScanDatabaseContext> options)
            : base(options)
            {

            }
        public DbSet<HomeController> Scans {get;set;}

        public object PostingScans { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostingScans>().HasData(new PostingScans(){ID=1});
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.LogTo(Console.WriteLine);

    }
}
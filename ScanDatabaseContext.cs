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
        public DbSet<PostingScans> Scans {get;set;}


        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<PostingScans>().HasData(new PostingScans(){ID=1});
            modelBuilder.Entity<PostingScans>().Property(b => b.CreatedTime ).HasDefaultValueSql("getdate()");
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
    => optionsBuilder.LogTo(Console.WriteLine);

    }
}
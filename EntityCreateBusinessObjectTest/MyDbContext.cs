using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace EntityCreateBusinessObjectTest
{
    public class MyDbContext
        :DbContext
    {

        public DbSet<User> Users { get; set; }

        public MyDbContext()
            :base()
        {         
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(@"Server=localhost\SQLEXPRESS;Database=TestDb;Trusted_Connection=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<User>()
                .ToTable("User");
            modelBuilder.Entity<User>()
                .HasKey(u => u.Id);
            //modelBuilder.Entity<User>()
            //    .Property(u => u.Id)
            //    .HasConversion(i => i.Value, id => new UserId(id));
            modelBuilder.Entity<User>()
                .OwnsOne(u => u.Name, un =>
                {
                    un.Property(x => x.First).HasColumnName("FirstName");
                    un.Property(x => x.Last).HasColumnName("LastName");
                });


        }
    }
}

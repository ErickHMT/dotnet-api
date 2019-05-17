using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore;
using webApi.Domain.Models;

namespace webApi.Persistence.Contexts
{
    public class AppDbContext : DbContext {

        public DbSet<Assignment> Assignments { get; set; }
        public DbSet<Employee> Employees { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options) { }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            base.OnModelCreating(modelBuilder);

            modelBuilder.Entity<Assignment>().ToTable("Assignments");
            modelBuilder.Entity<Assignment>().HasKey(p => p.Id);
            modelBuilder.Entity<Assignment>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Assignment>().Property(p => p.Description).IsRequired();
            modelBuilder.Entity<Assignment>().Property(p => p.Prediction);

            modelBuilder.Entity<Assignment>().HasData
            (
                new Assignment { Id = 100, Description = "Make some adjustments on background history" },
                new Assignment { Id = 101, Description = "Start a Prototype" }
            );  

            modelBuilder.Entity<Employee>().ToTable("Employee");
            modelBuilder.Entity<Employee>().HasKey(p => p.Id);
            modelBuilder.Entity<Employee>().Property(p => p.Id).IsRequired().ValueGeneratedOnAdd();
            modelBuilder.Entity<Employee>().Property(p => p.Name).IsRequired().HasMaxLength(80);
            modelBuilder.Entity<Employee>().Property(p => p.Email).IsRequired();
            modelBuilder.Entity<Employee>().Property(p => p.Department).IsRequired();
            modelBuilder.Entity<Employee>().HasMany(p => p.Assignments).WithOne(p => p.Employee).HasForeignKey(p => p.EmployeeId);

        }
    }
}

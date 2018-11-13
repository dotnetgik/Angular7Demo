using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Angular7DemoServices
{
    public class AppDbContext : DbContext
    {
        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {

        }
        public DbSet<Employee> tblemployee { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<Employee>().HasData(
            //    new Employee() { Fname = "Mangesh", Lname = "G", email = "Mangesh.g@outlook.com", gender = "1" },
            //    new Employee() { Fname = "Ramnath", Lname = "Bodke", email = "Ramnagh.g@outlook.com", gender = "1" },
            //    new Employee() { Fname = "Suraj", Lname = "G", email = "suraj.g@gmail.com", gender = "1" },
            //    new Employee() { Fname = "Jaffar", Lname = "K", email = "Jaffar.g@outlook.com", gender = "1" }
            //    );
        }
    }
}

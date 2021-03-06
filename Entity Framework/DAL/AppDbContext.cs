using Entity_Framework.Models;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;

namespace Entity_Framework.DAL
{
    internal class AppDbContext:DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            base.OnConfiguring(optionsBuilder);
            
            string connectionString = "Data Source=.;Initial Catalog=Blog;"
        + "Integrated Security=true;";
            optionsBuilder.UseSqlServer(connectionString);
        }
        public DbSet <Post> Posts{ get; set; }
    }
}

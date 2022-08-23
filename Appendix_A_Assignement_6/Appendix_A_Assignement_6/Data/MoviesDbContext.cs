//using Microsoft.EntityFrameworkCore;

using Microsoft.EntityFrameworkCore;
using System.Data.Entity;
using WebAPI.Models;

namespace Appendix_A_Assignement_6.Data
{
    public class MoviesDbContext : DbContext
    {
        

        public DbSet<Character> Character { get; set; }
        public DbSet<Franchise> Franchise { get; set; }
        public DbSet<Movies> Movies { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("WebApiDatabase"));
        }

    }
}

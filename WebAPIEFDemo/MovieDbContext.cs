using Microsoft.EntityFrameworkCore;
using WebAPIEFDemo.Models;

namespace WebAPIEFDemo
{
    public class MovieDbContext : DbContext
    {
        private readonly string _connectionString;

        public MovieDbContext(string connectionString)
        {
            _connectionString = connectionString;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer(_connectionString);
        }

        public DbSet<Movie> Movies { get; set; }
    }
}

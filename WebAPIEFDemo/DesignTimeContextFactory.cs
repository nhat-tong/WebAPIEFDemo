using Microsoft.EntityFrameworkCore.Design;

namespace WebAPIEFDemo
{
    public class DesignTimeContextFactory : IDesignTimeDbContextFactory<MovieDbContext>
    {
        public MovieDbContext CreateDbContext(string[] args)
        {
            var config = new ConfigurationBuilder()
               .SetBasePath(AppDomain.CurrentDomain.BaseDirectory)
               .AddJsonFile("appsettings.json")
               .Build();
            var connectionString = config.GetConnectionString("Default");
            return new MovieDbContext(connectionString);
        }
    }
}

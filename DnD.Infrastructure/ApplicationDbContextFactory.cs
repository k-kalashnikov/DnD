using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Design;
using Microsoft.Extensions.Configuration;

namespace DnD.Infrastructure
{
    public class ApplicationDbContextFactory : IDesignTimeDbContextFactory<ApplicationDbContext>
    {
        public ApplicationDbContext CreateDbContext(string[] args)
        {
            if (args.Length < 1)
            {
                throw new ArgumentException("Please enter configuration folder path. ", "args");
            }

            var currentPath = Path.GetFullPath(args[0]);

            var configuration = new ConfigurationBuilder()
                .SetBasePath(currentPath)
                .AddJsonFile("appsettings.json")
                .Build();

            var connectionString = configuration.GetConnectionString("SqliteConnectionString");

            Console.WriteLine($"Connection string is = {connectionString}");

            var optionBuilder = new DbContextOptionsBuilder<ApplicationDbContext>();
            optionBuilder.UseSqlite(connectionString);

            return new ApplicationDbContext(optionBuilder.Options);
        }
    }
}

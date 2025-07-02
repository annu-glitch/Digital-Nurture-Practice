using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using RetailInventoryProject.Models;

namespace RetailInventoryProject
{
    public class AppDbContext : DbContext
    {
        public DbSet<Product> Products { get; set; }
        public DbSet<Category> Categories { get; set; }

        public AppDbContext(DbContextOptions<AppDbContext> options) : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            /*if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseSqlServer("Server=localhost\\SQLEXPRESS;Database=RetailInventoryDB;Trusted_Connection=True;");
            }*/   //hardcoded


            //Load the config in DBContext
            var configBuilder = new ConfigurationBuilder()
            .AddJsonFile("appsettings.json")      //load the json file
            .Build();

            var connectionString = configBuilder
                .GetSection("ConnectionStrings")["SQLServerConnection"];    //load connection string section from json file and get SQLServerConnection key

            optionsBuilder.UseSqlServer(connectionString);    //pass value from the key-value pair in json file: the actual connection string
        }
    }
}

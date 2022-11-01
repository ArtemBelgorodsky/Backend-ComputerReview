using Computer_Backend.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System.Runtime.CompilerServices;

namespace Computer_Backend.Data
{
    public class ShopDBContext :DbContext
    {
        private IConfiguration _config;
        public ShopDBContext(DbContextOptions<ShopDBContext> options, IConfiguration config) : base(options)
        {
            _config = config;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            string connectionStr = _config.GetValue<string>("ConnectionStrings:WebApiDatabase");
            optionsBuilder.UseSqlite(connectionStr);
        }

        public DbSet<Article> Articles { get; set; }
    }
}

using System.IO;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Logging;
using Xamarin.Forms;
using XamarinEfCoreDemo.Data;

namespace XamarinEfCoreDemo.Models
{
    public class VegiContext : DbContext
    {
   
        public DbSet<Dish> Dishes { get; set; }
        public DbSet<Category> Categories { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {

            base.OnConfiguring(optionsBuilder);
            var loggerFactory = new LoggerFactory()
                .AddDebug();

            var path = Path.Combine(DependencyService.Get<IPathProvider>().GetDbFolder(), "dishes.db");
            optionsBuilder.UseLoggerFactory(loggerFactory);
            optionsBuilder.UseSqlite($"Filename={path}");
        }
    }
}
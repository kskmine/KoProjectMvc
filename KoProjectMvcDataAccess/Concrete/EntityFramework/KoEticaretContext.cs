using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using KoProjectMvcEntities.Concrete;
using Microsoft.Extensions.Configuration;

namespace KoProjectMvcDataAccess.Concrete.EntityFramework
{
    public class KoEticaretContext:DbContext
    {
        protected readonly IConfiguration Configuration;

        public KoEticaretContext(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public KoEticaretContext()
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder options)
        {
            // connect to sql server with connection string from app settings
            options.UseSqlServer(Configuration.GetConnectionString("KoEticaretDb"));
        }

       // public KoEticaretContext()
        //{
            //this.Configuration.LazyLoadingEnabled = false;
            //Database.SetInitializer<KoEticaretContext>(null);
        //}
        public DbSet<Category> Categories { get; set; }
        public DbSet<Color> Colors { get; set; }
        public DbSet<Customer> Customers { get; set; }
        public DbSet<Order> Orders { get; set; }
        public DbSet<Payment> Payments { get; set; }
        public DbSet<Product> Products { get; set; }
        public DbSet<Role> Roles { get; set; }
        public DbSet<Size> Sizes { get; set; }
        public DbSet<Complaint> Complaints { get; set; }

    }
}

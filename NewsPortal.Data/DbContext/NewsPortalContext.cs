//using Microsoft.AspNet.Identity.EntityFramework;
//using NewsPortal.Data.Configuration;
//using NewsPortal.Model.Models;
//using System.Data.Entity;

//namespace NewsPortal.Data.DbContext

//{
//    public class NewsPortalContext : IdentityDbContext
//    {
//        public NewsPortalContext() : base("NewsPortalContext")
//        {

//        }

//        public DbSet<Product> Products { get; set; }

//        public DbSet<Order> Orders { get; set; }

//        public DbSet<OrderItem> OrderItems { get; set; }

//        protected override void OnModelCreating(DbModelBuilder modelBuilder)
//        {
//            modelBuilder.Configurations.Add(new ProductConfiguration());

//            modelBuilder.Configurations.Add(new OrderConfiguration());

//            modelBuilder.Configurations.Add(new OrderItemConfiguration());


//        }
//    }
//}

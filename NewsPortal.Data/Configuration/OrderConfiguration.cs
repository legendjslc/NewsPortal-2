using NewsPortal.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace NewsPortal.Data.Configuration
{
    public class OrderConfiguration : EntityTypeConfiguration<Order>
    {
        public OrderConfiguration()
        {
            ToTable("Orders");
        }
    }
}

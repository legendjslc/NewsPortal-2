using NewsPortal.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace NewsPortal.Data.Configuration
{
    class OrderItemConfiguration : EntityTypeConfiguration<OrderItem>
    {
        public OrderItemConfiguration()
        {
            ToTable("OrderItems");
        }
    }
}

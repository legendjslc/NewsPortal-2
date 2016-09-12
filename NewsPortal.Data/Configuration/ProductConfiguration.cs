using NewsPortal.Model.Models;
using System.Data.Entity.ModelConfiguration;

namespace NewsPortal.Data.Configuration
{
    public class ProductConfiguration : EntityTypeConfiguration<Product>
    {
        public ProductConfiguration()
        {
            ToTable("ProductlarimBenim");
        }
    }
}

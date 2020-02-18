using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Mappings
{
    public class ProductMapping : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Price).IsRequired();
            builder.Property(x => x.Description).IsRequired();
        }
    }
}

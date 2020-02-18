using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Mappings
{
    public class OrderProductMapping : IEntityTypeConfiguration<OrderProduct>
    {
        public void Configure(EntityTypeBuilder<OrderProduct> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Quantity);
            builder.HasOne(x => x.Product);
            builder.HasOne(x => x.Order).WithMany(x => x.Products);
        }
    }
}

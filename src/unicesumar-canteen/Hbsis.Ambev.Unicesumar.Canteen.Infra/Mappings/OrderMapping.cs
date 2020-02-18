using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Mappings
{
    public class OrderMapping : IEntityTypeConfiguration<Order>
    {
        public void Configure(EntityTypeBuilder<Order> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Total).IsRequired();
            builder.Property(x => x.ClientName).IsRequired();
            builder.HasMany(x => x.Products).WithOne(x => x.Order);
        }
    }
}

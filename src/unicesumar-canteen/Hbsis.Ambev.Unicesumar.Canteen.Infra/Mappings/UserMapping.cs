using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra.Mappings
{
    public class UserMapping : IEntityTypeConfiguration<User>
    {
        public void Configure(EntityTypeBuilder<User> builder)
        {
            builder.HasKey(x => x.Id);
            builder.Property(x => x.Login);
            builder.Property(x => x.Password);
            builder.Property(x => x.Role);
        }
    }
}

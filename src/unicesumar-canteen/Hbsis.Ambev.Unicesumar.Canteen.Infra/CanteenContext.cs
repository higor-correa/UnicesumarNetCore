using Hbsis.Ambev.Unicesumar.Canteen.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;

namespace Hbsis.Ambev.Unicesumar.Canteen.Infra
{
    public class CanteenContext : DbContext
    {
        private readonly IConfiguration _configuration;

        public CanteenContext() { }

        public CanteenContext(DbContextOptions<CanteenContext> options, IConfiguration configuration) : base(options)
        {
            _configuration = configuration;
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
                optionsBuilder.UseNpgsql(_configuration.GetConnectionString("DefaultConnection"));
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new ProductMapping());
            modelBuilder.ApplyConfiguration(new OrderMapping());
            modelBuilder.ApplyConfiguration(new OrderProductMapping());

            base.OnModelCreating(modelBuilder);
        }
    }
}

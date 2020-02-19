using Hbsis.Ambev.Unicesumar.Canteen.Domain.Products;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using Hbsis.Ambev.Unicesumar.Canteen.Infra.Mappings;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using System;

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
            modelBuilder.ApplyConfiguration(new UserMapping());

            var random = new Random();
            modelBuilder.Entity<Product>().HasData(
                new Product(Guid.Parse("38df74cfbbf14c47a513b51192162675"), "Adriática", 27.11m),
                new Product(Guid.Parse("f9fa7a5528ef4daca938170bc8c8e86e"), "Antarctica", 22.14m),
                new Product(Guid.Parse("cb91f1d0726f4a8496d1419e3fe1582d"), "Beck's", 14.17m),
                new Product(Guid.Parse("c292141a21044afc8431596e40b0e783"), "Bohemia", 16.44m),
                new Product(Guid.Parse("5b682ec640dc4e71a10f4a0d9dff6b31"), "Brahma", 4.29m),
                new Product(Guid.Parse("bea953df7d784364b2c8953d1467aef9"), "Budweiser", 29.67m),
                new Product(Guid.Parse("1623b63ddb674447846052a840ac6f68"), "Caracu", 24.22m),
                new Product(Guid.Parse("fe7edab42b64416ab0205bfe8b0790bd"), "Cervejaria Colorado", 9.28m),
                new Product(Guid.Parse("6acd2a474f54483ebda56e8845024ef0"), "Corona", 5.68m),
                new Product(Guid.Parse("31d1631a04784843805566114c5c79ee"), "Franziskaner", 11.14m),
                new Product(Guid.Parse("6f596be28b2648acb85d3a4fb3a647a4"), "Goose Island", 10.7m),
                new Product(Guid.Parse("46c6ec9441e24564a99bf67e487ae7ff"), "Hertog Jan", 11.71m),
                new Product(Guid.Parse("908dfa2f45b5480f82a0a0ac0eb8c72d"), "Hoegaarden", 8.87m),
                new Product(Guid.Parse("3b45bc7db6a749158007fffee5bc1dd6"), "Leffe", 8.8m),
                new Product(Guid.Parse("ad99c2ebbeab4a2b85ebfba15ea45864"), "Legítima", 19.6m),
                new Product(Guid.Parse("2c013e774d8e412e9492f3c2d0be748b"), "Löwenbräu", 11.19m),
                new Product(Guid.Parse("3964bb46b21a473e81c28d9e648822fe"), "Magnífica do Maranhão", 28.29m),
                new Product(Guid.Parse("c0d623b76dc247a590febb266d338e76"), "Norteña", 2.77m),
                new Product(Guid.Parse("2d410954d7704d8f865a63f26e58c757"), "Nossa", 10.64m),
                new Product(Guid.Parse("d0c03fda11834a9eba50abb0dc0e466d"), "Original", 9.2m),
                new Product(Guid.Parse("dcb961663eff4d2db79f06315ec3f2be"), "Patagonia", 25.39m),
                new Product(Guid.Parse("5ce4210aa73f464a9cef86df80fa3ea7"), "Polar", 10.92m),
                new Product(Guid.Parse("2dd4bedbb7e74f05994166bb2b4b7886"), "Quilmes", 2.94m),
                new Product(Guid.Parse("d9470a0fee7341ff85f6fd9fc76d4bec"), "Serramalte", 5.15m),
                new Product(Guid.Parse("9f52b74d70ff42cd816642b4d4227dce"), "Serrana", 12.45m),
                new Product(Guid.Parse("da436ba608304e4f8037dc7875df8285"), "Skol", 1.44m),
                new Product(Guid.Parse("41ab0c5904a645d6ac20ef15e8a10d4e"), "Stella Artois", 22.31m),
                new Product(Guid.Parse("8a234d726b3244c2b7c151b5186f0750"), "Três Fidalgas", 25.59m),
                new Product(Guid.Parse("147e4c5ea2284188abfc8f612b1b7096"), "Wäls", 8.88m)
            );
            modelBuilder.Entity<User>().HasData(
                new User(Guid.Parse("cc915b3a-0d98-451e-99c8-d2988079737f"), "higor", "higor", "hbsis", "administrator"),
                new User(Guid.Parse("e7815408-72fa-40e6-b631-ec4fc44e6a6f"), "matheus", "matheus", "hbsis", "manager"),
                new User(Guid.Parse("0166fcd6-02f6-4a94-a3af-7b15f8a2d33f"), "hugo", "hugo", "hbsis", "client")
            );
            base.OnModelCreating(modelBuilder);
        }

        private decimal RandomPrice(Random random)
        {
            var value = (decimal)random.Next(1, 30);
            var cents = (decimal)random.Next(0, 99);
            return value + (cents / 100);
        }
    }
}

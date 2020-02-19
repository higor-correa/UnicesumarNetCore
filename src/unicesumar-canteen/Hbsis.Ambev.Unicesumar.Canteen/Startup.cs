using AutoMapper;
using Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Authentications;
using Hbsis.Ambev.Unicesumar.Canteen.Api.Configurations.Middlewares;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Notifications;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Orders;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Repositories;
using Hbsis.Ambev.Unicesumar.Canteen.Domain.Users;
using Hbsis.Ambev.Unicesumar.Canteen.Infra;
using Hbsis.Ambev.Unicesumar.Canteen.Infra.Notifications;
using Hbsis.Ambev.Unicesumar.Canteen.Infra.Repositories;
using Hbsis.Ambev.Unicesumar.Canteen.Infra.Transactions;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Hbsis.Ambev.Unicesumar.Canteen.Api
{
    public class Startup
    {
        public Startup(IConfiguration configuration)
        {
            Configuration = configuration;
        }

        public IConfiguration Configuration { get; }

        // This method gets called by the runtime. Use this method to add services to the container.
        public void ConfigureServices(IServiceCollection services)
        {
            var connectionString = Configuration.GetConnectionString("DefaultConnection");

            services.AddDbContext<CanteenContext>(opt => opt.UseNpgsql(connectionString));
            services.AddScoped<DbContext, CanteenContext>();
            services.AddScoped<IDomainNotification, DomainNotification>();
            services.AddScoped<ITransaction, Transaction>();
            services.AddScoped<IScopedContext, ScopedContext>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderProductService, OrderProductService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderProductRepository, OrderProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();

            services.AddAutoMapper(typeof(Startup));

            services.AddControllers();
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            UpdateDatabase(app);

            app.UseMiddleware<TransactionMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            app.UseAuthorization();

            app.UseEndpoints(endpoints =>
            {
                endpoints.MapControllers();
            });
        }

        private void UpdateDatabase(IApplicationBuilder app)
        {
            var serviceScope = app.ApplicationServices.GetService<IServiceScopeFactory>().CreateScope();
            var context = serviceScope.ServiceProvider.GetRequiredService<CanteenContext>();
            context.Database.Migrate();
        }

    }
}

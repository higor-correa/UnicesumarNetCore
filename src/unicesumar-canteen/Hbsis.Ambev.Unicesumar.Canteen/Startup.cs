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
using Microsoft.AspNetCore.Authentication.JwtBearer;
using Microsoft.AspNetCore.Builder;
using Microsoft.AspNetCore.Hosting;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Text;

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
            services.AddScoped<ILoginService, LoginService>();

            services.AddScoped<IOrderService, OrderService>();
            services.AddScoped<IOrderProductService, OrderProductService>();
            services.AddScoped<IOrderRepository, OrderRepository>();
            services.AddScoped<IOrderProductRepository, OrderProductRepository>();
            services.AddScoped<IProductRepository, ProductRepository>();
            services.AddScoped<IUserRepository, UserRepository>();

            services.AddAutoMapper(typeof(Startup));

            services.AddCors();
            services.AddControllers();
            AddAuthentication(services);
        }

        // This method gets called by the runtime. Use this method to configure the HTTP request pipeline.
        public void Configure(IApplicationBuilder app, IWebHostEnvironment env)
        {
            if (env.IsDevelopment())
            {
                app.UseDeveloperExceptionPage();
            }

            UpdateDatabase(app);

            app.UseCors(x =>
            {
                x.AllowAnyOrigin();
                x.AllowAnyHeader();
                x.AllowAnyMethod();
            });

            app.UseMiddleware<TransactionMiddleware>();

            app.UseHttpsRedirection();

            app.UseRouting();

            UseAuthentication(app);

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

        #region Authentication

        private void UseAuthentication(IApplicationBuilder app)
        {
            app.UseAuthentication();
            app.UseAuthorization();
        }

        private void AddAuthentication(IServiceCollection services)
        {
            var key = Encoding.ASCII.GetBytes(Configuration.GetSection("Secret").Value);
            services.AddAuthentication(x =>
            {
                x.DefaultAuthenticateScheme = JwtBearerDefaults.AuthenticationScheme;
                x.DefaultChallengeScheme = JwtBearerDefaults.AuthenticationScheme;
            })
            .AddJwtBearer(x =>
            {
                x.RequireHttpsMetadata = false;
                x.SaveToken = true;
                x.TokenValidationParameters = new TokenValidationParameters
                {
                    ValidateIssuerSigningKey = true,
                    IssuerSigningKey = new SymmetricSecurityKey(key),
                    ValidateIssuer = false,
                    ValidateAudience = false
                };
            });
        } 
        #endregion
    }
}

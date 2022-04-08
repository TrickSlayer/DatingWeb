using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace API.Extentions
{
    public static class ApplicationServiceExtensions
    {
        public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration config)
        {
            services.AddScoped<ITokenService, TokenService>();
            services.AddDbContext<DatingAppContext>();

            return services;
        }

        public static IApplicationBuilder AddApplicationBuilder(this IApplicationBuilder app)
        {
            app.UseCors(x => x
                .AllowAnyHeader()
                .AllowAnyOrigin()
                .AllowAnyMethod()
            );

            return app;
        }
    }
}

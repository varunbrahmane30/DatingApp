using System;
using System.Reflection.Metadata.Ecma335;
using API.Data;
using API.Interfaces;
using API.Services;
using Microsoft.EntityFrameworkCore;

namespace API.Extensions
{
    public static class ApplicationServiceExtension
    {
        public static IServiceCollection AddApplicationservices(this IServiceCollection services, IConfiguration config)
        {
            services.AddDbContext<DataContext>(opt => 
        {
            DbContextOptionsBuilder dbContextOptionsBuilder = opt.UseSqlite(config.GetConnectionString("DefaultConnection"));
        });

        services.AddScoped<ITokenservice, TokenService>();

        services.AddCors();
        
        return services;
        }

    }
}

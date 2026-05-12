using Application.Features.Users;
using Application.Interfaces;
using Infrastructure.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace Infrastructure.Persistence
{
    public static class BdStreamerDI
    {
        public static IServiceCollection AddInfrastructureService(this IServiceCollection services, IConfiguration configuration)
        {
            var connectionString = configuration.GetConnectionString("BD");
            services.AddDbContext<AppDbContext>(options=>options.UseSqlServer(connectionString));
            services.AddScoped<IUserRepository,UserRepository>();
            services.AddScoped<CreateUserCommandHandler>();
            return services;
        }
    }
}

using GerenciadorFluxo.Application.Contracts;
using GerenciadorFluxo.Application.Services;
using GerenciadorFluxo.Domain.Contracts;
using GerenciadorFluxo.Infra.Data.Context;
using GerenciadorFluxo.Infra.Data.Repositories;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;

namespace GerenciadorFluxo.Infra.IoC
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<ApplicationDbContext>(
                options => options.UseSqlServer(configuration.GetConnectionString("DefaultConnection"),
                b => b.MigrationsAssembly(typeof(ApplicationDbContext).Assembly.FullName)));

            services.AddScoped<IFluxoRepository, FluxoRepository>();
            services.AddScoped<IFluxoService, FluxoService>();
            services.AddScoped<IProcessoRepository, ProcessoRepository>();
            services.AddScoped<IProcessoService, ProcessoService>();

            services.AddAutoMapper(typeof(MappingProfile));

            return services;
        }
    }
}
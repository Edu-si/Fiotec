using DevIO.Business.Intefaces;
using DevIO.Business.Notificacoes;
using DevIO.Business.Services;
using DevIO.Data.Context;
using DevIO.Data.Repository;

namespace Aplicacao.Configuration
{
    public static class DependencyInjectionConfig
    {
        public static IServiceCollection ResolveDependencies(this IServiceCollection services)
        {
            services.AddScoped<MeuDbContext>();
            services.AddScoped<IClienteRepository, ClienteRepository>();
            services.AddScoped<IRelatorioRepository, RelatorioRepository>();
       
           

            services.AddScoped<INotificador, Notificador>();
            services.AddScoped<IClienteService, ClienteService>();
            services.AddScoped<IRelatorioService, RelatorioService>();

           

            return services;
        }
    }
}

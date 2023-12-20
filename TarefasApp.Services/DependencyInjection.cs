using TarefasApp.Domain.Interfaces.Services;
using TarefasApp.Domain.Interfaces.Repositories;
using TarefasApp.Domain.Services;
using TarefasApp.Infra.Data.Repositories;

namespace TarefasApp.Services
{
    /// <summary>
    /// Classe para configurar as injeções de dependência do projeto
    /// </summary>
    public class DependencyInjection
    {
        /// <summary>
        /// Método para configurar as injeções de dependência do sistema
        /// </summary>
        public static void Register(IServiceCollection services)
        {
            services.AddTransient < ITarefaDomainService, TarefaDomainService >();
            services.AddTransient<ITarefaRepository, TarefaRepository>();
            services.AddTransient<ICategoriaRepository, CategoriaRepository>();
            services.AddTransient<ICategoriaDomainService, CategoriaDomainService >();
        }
    }
}




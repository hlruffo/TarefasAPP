using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;
using TarefasApp.Domain.Interfaces.Repositories;
using TarefasApp.Domain.Interfaces.Services;

namespace TarefasApp.Domain.Services
{
    public class CategoriaDomainService : ICategoriaDomainService
    {
        private readonly ICategoriaRepository? _categoriaRepository;

        public CategoriaDomainService(ICategoriaRepository? categoriaRepository)
        {
            _categoriaRepository = categoriaRepository;
        }

        public List<Categoria>? Consultar()
        {
            return _categoriaRepository?.GetAll().OrderBy(c=>c.Nome).ToList();
        }
    }
}

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
        private readonly ICategoriaRepository? _categoriarepository;

        public CategoriaDomainService(ICategoriaRepository? categoriarepository)
        {
            _categoriarepository = categoriarepository;
        }

        public List<Categoria> Consultar()
        {
            throw new NotImplementedException();
        }
    }
}

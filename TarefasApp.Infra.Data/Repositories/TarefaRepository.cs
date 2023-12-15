using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;
using TarefasApp.Domain.Interfaces.Repositories;

namespace TarefasApp.Infra.Data.Repositories
{
    /// <summary>
    /// Repositorio do banco de dados para tarefa
    /// </summary>
    public class TarefaRepository : BaseRepository<Tarefa>, ITarefaRepository
    {

    }
}

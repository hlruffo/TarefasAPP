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
    /// <summary>
    /// Classe de serviços de dominio para tarefa
    /// </summary>
    public class TarefaDomainService : ITarefaDomainService
    {
        private readonly ITarefaRepository? _tarefaRepository;

        public TarefaDomainService(ITarefaRepository? tarefaRepository)
        {
            _tarefaRepository = tarefaRepository;
        }

        public void Cadastrar(Tarefa tarefa)
        {
          _tarefaRepository?.Add(tarefa);
        }
    }
}

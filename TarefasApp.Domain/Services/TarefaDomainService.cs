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
        private readonly ICategoriaRepository? _categoriaRepository;

        public TarefaDomainService(ITarefaRepository? tarefaRepository, ICategoriaRepository? categoriaRepository)
        {
            _tarefaRepository = tarefaRepository;
            _categoriaRepository = categoriaRepository;
        }

        public void Atualizar(Tarefa tarefa)
        {
            //verificar se o id da tarefa existe no banco de dados
            if (_tarefaRepository?.GetById(tarefa.Id.Value) == null)
                throw new ApplicationException("A tarefa informada não existe. Por favor, verifique.");

            // verifica se a categoria informada não existe no banco de dados
            if (_categoriaRepository?.GetById(tarefa.CategoriaId.Value) == null)
                throw new ApplicationException("A categoria informada não existe. Por favor, verifique");

            //atualizar a tarefa
            _tarefaRepository.Update(tarefa);  
        }

        public void Cadastrar(Tarefa tarefa)
        {
            //verifica se a categoria informada existe no BD
            if (_categoriaRepository?.GetById(tarefa.CategoriaId.Value) == null)
                throw new ApplicationException("A Categoria informada não existe. Por favor, verifique.");

            _tarefaRepository?.Add(tarefa);
        }

        public List<Tarefa>? Consultar()
        {
            return _tarefaRepository?.GetAll();
        }

        public void Excluir(Guid id)
        {
            //buscar a tarefa no bd atraves do id
            var tarefa = _tarefaRepository?.GetById(id);

            //verificar se o id da tarefa existe no banco de dados
            if (tarefa == null)
                throw new ApplicationException("A tarefa informada não existe. Por favor, verifique.");

            //excluir tarefa
            _tarefaRepository?.Delete(tarefa);

        }

        public Tarefa? ObterPorId(Guid id)
        {
            return _tarefaRepository?.GetById(id);
        }
    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using TarefasApp.Domain.Entities;

namespace TarefasApp.Domain.Interfaces.Services
{
    /// <summary>
    /// interface para os métodos de serviço de dominio de tarefa
    /// </summary>
    public interface ITarefaDomainService
    {
        void Cadastrar(Tarefa tarefa); 
        void Atualizar(Tarefa tarefa);
        void Excluir(Guid id);

        List<Tarefa> Consultar();
        Tarefa ObterPorId(Guid id);

    }
}

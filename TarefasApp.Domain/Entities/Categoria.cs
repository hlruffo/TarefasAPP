using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.Domain.Entities
{
    /// <summary>
    /// modelo de entidade para o Banco de dados
    /// </summary>
    public class Categoria
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }

        #region Relacionamentos
        public List<Tarefa>? Tarefas { get; set; }
        #endregion
    }
}

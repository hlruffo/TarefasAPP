using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TarefasApp.Domain.Entities
{
    public class Tarefa
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataHora { get; set; }
        public string? Descricao { get; set; }
        public PrioridadeTarefa? Prioridade { get; set;}

        public Guid? CategoriaId { get; set; }

        #region
        public Categoria? Categoria { get; set; }

        #endregion
    }
    /// <summary>
    /// Enum para definir prioridade
    /// </summary>
    public enum PrioridadeTarefa
    {
        Baixa = 1,
        Media = 2,
        Alta = 3
    }
}

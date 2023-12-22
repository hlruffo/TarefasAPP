using TarefasApp.Domain.Entities;

namespace TarefasApp.Services.Models
{
    /// <summary>
    /// Modelo de dados para consulta de tarefas na API
    /// GET /api/tarefas
    /// </summary>
    public class TarefasGetModel
    {
        public Guid? Id { get; set; }
        public string? Nome { get; set; }
        public DateTime? DataHora { get; set; }
        public string? Descricao { get; set; }
        public int? Prioridade { get; set; }
        public Guid? CategoriaId { get; set; }
    }
}




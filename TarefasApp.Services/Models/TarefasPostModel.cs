using System.ComponentModel.DataAnnotations;

namespace TarefasApp.Services.Models
{
    public class TarefasPostModel
    {
        [Required(ErrorMessage = "Por favor, informe o nome da tarefa.")]
        [MinLength(8, ErrorMessage = "Por favor, informe o mínimo de {1} caractéres.")]
        [MaxLength(100, ErrorMessage = "Por favor, informe o máximo de {1} caractéres.")]
        public string? Nome { get; set; }

        [Required(ErrorMessage = "Por favor, informe a data e hora da tarefa.")]
        public DateTime? DataHora { get; set;}

        [Required(ErrorMessage = "Por favor, informe a descrição  da tarefa.")]
        [MinLength(8, ErrorMessage = "Por favor, informe o mínimo de {1} caractéres.")]
        [MaxLength(250, ErrorMessage = "Por favor, informe o máximo de {1} caractéres.")]
        public string? Descricao { get; set; }


        [Required(ErrorMessage = "Por favor, informe a prioridade da tarefa.")]
        [Range(1,3, ErrorMessage ="Por favor, informe valor 1(Baixa), 2(Média) ou 3(Alta) para prioridade")]
        public int? Prioridade { get; set; }


        [Required(ErrorMessage ="Por favor, informe o id da Categoria")]
        public Guid? CategoriaID { get; set; }      
    }
}

using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefasApp.Domain.Entities;
using TarefasApp.Domain.Interfaces.Services;
using TarefasApp.Services.Models;

namespace TarefasApp.Services.Controllers
{
    /// <summary>
    /// Classe de controle para o ENDPOINT de serviço de tarefas da API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        private readonly ITarefaDomainService? _tarefaDomainService;

        public TarefasController(ITarefaDomainService? tarefaDomainService)
        {
            _tarefaDomainService = tarefaDomainService;
        }

        /// <summary>
        /// Método para cadastrar tarefas.
        /// </summary>
        [HttpPost]
        public IActionResult Post([FromBody] TarefasPostModel model)
        {
            var tarefa = new Tarefa
            {
                Id = Guid.NewGuid(),
                Nome = model.Nome,
                DataHora = model.DataHora,
                Descricao = model.Descricao,
                Prioridade = (PrioridadeTarefa?)model.Prioridade
            };

            _tarefaDomainService?.Cadastrar(tarefa);
            return Ok("Cadastro de tarefa realizado com sucesso!");
        }

        /// <summary>
        /// Método para atualizar tarefas.
        /// </summary>
        [HttpPut]
        public IActionResult Put()
        {
            return Ok("Edição de tarefa!");
        }

        /// <summary>
        /// Método para exclusão de tarefas.
        /// </summary>
        [HttpDelete]
        public IActionResult Delete()
        {
            return Ok("Exclusão de tarefa!");
        }

        /// <summary>
        /// Método para consulta de tarefas.
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            return Ok("Consulta de tarefas!");
        }
    }
}




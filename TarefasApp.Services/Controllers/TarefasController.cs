using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TarefasApp.Services.Controllers
{
    /// <summary>
    /// Classe de controle para o ENDPOINT de serviço de tarefas da API
    /// </summary>
    [Route("api/[controller]")]
    [ApiController]
    public class TarefasController : ControllerBase
    {
        /// <summary>
        /// Método para cadastrar tarefas.
        /// </summary>
        [HttpPost]
        public IActionResult Post()
        {
            return Ok("Cadastro de tarefa!");
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




using AutoMapper;
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
        private readonly IMapper? _mapper;
       
        public TarefasController(ITarefaDomainService? tarefaDomainService, IMapper? mapper)
        {
            _tarefaDomainService = tarefaDomainService;
            _mapper = mapper;
        }

        /// <summary>
        /// Método para cadastrar tarefas.
        /// </summary>
        [HttpPost]
        public IActionResult Post([FromBody] TarefasPostModel model)
        {
            try
            {
                var tarefa = _mapper?.Map<Tarefa>(model);
                _tarefaDomainService?.Cadastrar(tarefa);
                return StatusCode(201, new
                { mensagem ="Tarefa cadastrada com sucesso.",
                    Id = tarefa.Id
                });
            }
            catch(ApplicationException e)
            {
                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// Método para atualizar tarefas.
        /// </summary>
        [HttpPut]
        public IActionResult Put([FromBody] TarefasPutModel model)
        {
            try
            {
                var tarefa = _mapper?.Map<Tarefa>(model);
                _tarefaDomainService?.Cadastrar(tarefa);
                return StatusCode(201, new
                {
                    mensagem = "Tarefa atualizada com sucesso.",
                    Id = tarefa.Id
                });
            }
            catch (ApplicationException e)
            {
                return StatusCode(400, new { e.Message });
            }
            catch (Exception e)
            {
                return StatusCode(500, new { e.Message });
            }
        }

        /// <summary>
        /// Método para exclusão de tarefas.
        /// </summary>
        [HttpDelete("{id}")]
        public IActionResult Delete(Guid id)
        {
            try
            {
                return StatusCode(204, new
                {
                    mensagem = "Tarefa excluída com sucesso.",
                    Id = id
                });

            }
            catch(ApplicationException e)
            {
                return StatusCode(400, new
                {
                    mensagem = e.Message
                });
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    mensagem = e.Message
                });
            }
        }

        /// <summary>
        /// Método para consulta de tarefas.
        /// </summary>
        [HttpGet]
        public IActionResult Get()
        {
            try
            {
                var tarefas = _mapper?.Map<List<TarefasGetModel>>(_tarefaDomainService.Consultar());
                return StatusCode(200, tarefas);
            }
            catch(Exception e)  
            {
                return StatusCode(500, new
                {
                    mensagem = e.Message
                });
            }
        }

        [HttpGet("{id}")]
        public IActionResult Get(Guid id)
        {
            try
            {
                var tarefa = _mapper?.Map<TarefasGetModel>(_tarefaDomainService.ObterPorId(id));
                return StatusCode(200, tarefa);
            }
            catch (Exception e)
            {
                return StatusCode(500, new
                {
                    mensagem = e.Message
                });
            }
        }
    }
}




using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using TarefasApp.Domain.Interfaces.Services;

namespace TarefasApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        private readonly ICategoriaDomainService? _categoriaDomainService;

        public CategoriasController(ICategoriaDomainService? categoriaDomainService)
        {
            _categoriaDomainService = categoriaDomainService;
        }

        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

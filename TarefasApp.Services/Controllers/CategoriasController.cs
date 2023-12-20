using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace TarefasApp.Services.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoriasController : ControllerBase
    {
        [HttpGet]
        public IActionResult Get()
        {
            return Ok();
        }
    }
}

using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Serilog;

namespace Injecao.Dependencia.Controllers
{
    [ApiController]
    [Route("TesteInjecaoDepenciaController")]
    public class TesteInjecaoDepenciaUnicaController : ControllerBase
    {

        private readonly ILogger _logger;
        private readonly IMetodoDidaticoParaInjecaoUnicaApp _unica;

        public TesteInjecaoDepenciaUnicaController(IMetodoDidaticoParaInjecaoUnicaApp scoped)
        {
            _logger = Log.ForContext<TesteInjecaoDepenciaUnicaController>();
            _unica = scoped;
        }


        [HttpGet]
        [Route("TesteUnico")]
        public void TesteUnico()
        {
            _unica.TesteDeLog();
        }
    }
}

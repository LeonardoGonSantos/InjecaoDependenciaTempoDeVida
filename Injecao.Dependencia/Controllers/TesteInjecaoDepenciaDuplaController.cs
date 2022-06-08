using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;

namespace Injecao.Dependencia.Controllers
{
    [ApiController]
    [Route("TesteInjecaoDepenciaController")]
    public class TesteInjecaoDepenciaDuplaController : ControllerBase
    {

        private readonly ILogger _logger;
        private readonly IMetodoDidaticoParaInjecaoDuplaApp _dupla;

        public TesteInjecaoDepenciaDuplaController(IMetodoDidaticoParaInjecaoDuplaApp dupla)
        {
            _logger = Log.ForContext<TesteInjecaoDepenciaDuplaController>();
            _dupla = dupla;
        }


        [HttpGet]
        [Route("TesteDuplo")]
        public void TesteDuplo()
        {
            _dupla.TesteDeLog();
            _logger.Information("");
        }
    }
}

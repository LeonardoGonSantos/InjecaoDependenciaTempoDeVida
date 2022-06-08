using Application.Interface;
using Microsoft.AspNetCore.Mvc;
using Serilog;
using System;
using System.Diagnostics;

namespace Injecao.Dependencia.Controllers
{
    [ApiController]
    [Route("testeGc")]
    public class TesteGc : ControllerBase
    {

        private readonly ILogger _logger;
        private readonly IValidaCpfApp _dupla;

        public TesteGc(IValidaCpfApp dupla)
        {
            _logger = Log.ForContext<TesteGc>();
            _dupla = dupla;
        }


        [HttpGet]
        [Route("testeGc")]
        public void TesteDuplo()
        {
            var sw = new Stopwatch();
            var before2 = GC.CollectionCount(2);
            var before1 = GC.CollectionCount(1);
            var before0 = GC.CollectionCount(0);

            sw.Start();

            _dupla.validaCpf("teste");

            GC.SuppressFinalize(sw);

            sw.Stop();

            _logger.Information($"Tempo total: {sw.ElapsedMilliseconds}ms");
            _logger.Information($"GC Gen #2 : {GC.CollectionCount(2) - before2}");
            _logger.Information($"GC Gen #1 : {GC.CollectionCount(1) - before1}");
            _logger.Information($"GC Gen #0 : {GC.CollectionCount(0) - before0}");
        }


    }
}

using Application.Interface;
using Services.Interface;
using Serilog;
using System;

namespace Application
{
    public class MetodoDidaticoParaInjecaoUnicaApp : IMetodoDidaticoParaInjecaoUnicaApp
    {
        private ILogger _logger;
        private Guid numeroUnico = Guid.NewGuid();
        private int count;

        public MetodoDidaticoParaInjecaoUnicaApp()
        {
            _logger = Log.ForContext<MetodoDidaticoParaInjecaoUnicaApp>();

            _logger.Information($"Identificador de build {numeroUnico} : Recriado a {this.GetType().Name}");
        }

        public void TesteDeLog()
        {
            _logger.Information($"Identificador de build {numeroUnico} : utilizando method");
            count += 1;

            _logger.Information($"count de requisição {count}");
        }
    }
}

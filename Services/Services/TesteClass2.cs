using Services.Interface;
using System;
using Serilog;

namespace Services
{
    public class TesteClass2 : ITesteClass2
    {
        private ILogger _logger;
        private Guid numeroUnico = Guid.NewGuid();

        public TesteClass2()
        {
            _logger = Log.ForContext<TesteClass2>();

            _logger.Information($"Identificador de build {numeroUnico} : Recriado a {this.GetType().Name}");
        }

        public void Teste()
        {
            _logger.Information($"Identificador de build {numeroUnico} : utilizando method");
        }
    }
}

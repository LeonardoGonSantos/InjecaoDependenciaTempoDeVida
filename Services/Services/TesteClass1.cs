using Services.Interface;
using System;
using Serilog;
using System;

namespace Services
{
    public class TesteClass1 : ITesteClass1
    {

        private ILogger _logger;
        private Guid numeroUnico = Guid.NewGuid();

        public TesteClass1()
        {
            _logger = Log.ForContext<TesteClass1>();

            _logger.Information($"Identificador de build {numeroUnico} : Recriado a {this.GetType().Name}");

        }

        public void Teste()
        {
            _logger.Information($"Identificador de build {numeroUnico} : utilizando method");
        }
    }
}

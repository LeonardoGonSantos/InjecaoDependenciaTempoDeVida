using Application.Interface;
using Services.Interface;
using Serilog;
using System;
using Teste.Performance;

namespace Application
{
    public class ValidaCpfApp : IValidaCpfApp
    {
        private ILogger _logger;
        private Guid numeroUnico = Guid.NewGuid();

        public ValidaCpfApp()
        {
            _logger = Log.ForContext<MetodoDidaticoParaInjecaoUnicaApp>();

            _logger.Information($"Identificador de build {numeroUnico} : Recriado a {this.GetType().Name}");
        }

        public void validaCpf(string cpf)
        {
            _logger.Information($"Identificador de build {numeroUnico} : utilizando method");


            Func<string, bool> sut = Original.ValidarCPF;

            for (int i = 0; i < 1000000; i++)
            {
                if (!sut("771.189.500-33"))
                {
                    throw new Exception("Error!");
                }

                if (sut("771.189.500-34"))
                {
                    throw new Exception("Error!");
                }
            }
        }
    }
}

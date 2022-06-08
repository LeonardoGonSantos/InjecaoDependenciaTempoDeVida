using Application.Interface;
using Services.Interface;
using Serilog;
using System;

namespace Application
{ 
    public class MetodoDidaticoParaInjecaoDuplaTransientApp : IMetodoDidaticoParaInjecaoDuplaApp
    {

        private ITesteClass2 _class2;
        private ITesteClass1 _class1;
        private ILogger _logger;
        private Guid numeroUnico = Guid.NewGuid();

        public MetodoDidaticoParaInjecaoDuplaTransientApp(ITesteClass2 class2, ITesteClass1 class1)
        {
            _class2 = class2;
            _class1 = class1;
            _logger = Log.ForContext<MetodoDidaticoParaInjecaoDuplaTransientApp>();

            _logger.Information($"Identificador de build {numeroUnico} : Recriado a {this.GetType().Name}");
        }

        public void TesteDeLog()
        {
            _class2.Teste();
            _class2.Teste();
            _class1.Teste();
            _class1.Teste();
        }
    }
}

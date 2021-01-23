using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Logging;
using System.Collections.Generic;
using System.Diagnostics;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosCNHDecoratorLogger : IDetranVerificadorPontosCNHService
    {
        private readonly IDetranVerificadorPontosCNHService _Inner;
        private readonly ILogger<DetranVerificadorPontosCNHDecoratorLogger> _Logger;

        public DetranVerificadorPontosCNHDecoratorLogger(
            IDetranVerificadorPontosCNHService inner,
            ILogger<DetranVerificadorPontosCNHDecoratorLogger> logger)
        {
            _Inner = inner;
            _Logger = logger;
        }

        public async Task<IEnumerable<Pontos>> ConsultarPontos(Motorista motorista)
        {
            Stopwatch watch = Stopwatch.StartNew();
            _Logger.LogInformation($"Iniciando a execução do método ConsultarDebitos({motorista})");
            var result = await _Inner.ConsultarDebitos(motorista);
            watch.Stop(); 
            _Logger.LogInformation($"Encerrando a execução do método ConsultarDebitos({motorista}) {watch.ElapsedMilliseconds}ms");
            return result;
        }
    }
}
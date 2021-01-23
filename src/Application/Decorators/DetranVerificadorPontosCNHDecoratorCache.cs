using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Services;
using Microsoft.Extensions.Caching.Distributed;
using System.Collections.Generic;
using System.Threading.Tasks;
using Workbench.IDistributedCache.Extensions;

namespace DesignPatternSamples.Application.Decorators
{
    public class DetranVerificadorPontosCNHDecoratorCache : IDetranVerificadorPontosCNHService
    {
        private readonly IDetranVerificadorPontosCNHService _Inner;
        private readonly IDistributedCache _Cache;

        public DetranVerificadorPontosCNHDecoratorCache(
            IDetranVerificadorPontosCNHService inner,
            IDistributedCache cache)
        {
            _Inner = inner;
            _Cache = cache;
        }

        public Task<IEnumerable<Pontos>> ConsultarPontos(Motorista motorista)
        {
            return Task.FromResult(_Cache.GetOrCreate($"{motorista.CNH}_{motorista.Pontos}", () => _Inner.ConsultarPontos(motorista).Result));
        }
    }
}
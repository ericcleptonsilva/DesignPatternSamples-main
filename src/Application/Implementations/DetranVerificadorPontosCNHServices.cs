using DesignPatternSamples.Application.DTO;
using DesignPatternSamples.Application.Repository;
using DesignPatternSamples.Application.Services;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Implementations
{
    public class DetranVerificadorPontosCNHServices : IDetranVerificadorPontosCNHService
    {
        private readonly IDetranVerificadorPontosCNHFactory _Factory;

        public DetranVerificadorPontosCNHServices(IDetranVerificadorPontosCNHFactory factory)
        {
            _Factory = factory;
        }

        public Task<IEnumerable<Pontos>> ConsultarPontos(Motorista motorista)
        {
            IDetranVerificadorPontosCNHRepository repository = _Factory.Create(motorista.CNH);
            return repository.ConsultarPontos(motorista);
        }
    }
}

using DesignPatternSamples.Application.DTO;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace DesignPatternSamples.Application.Services
{
    public interface IDetranVerificadorPontosCNHService
    {
        Task<IEnumerable<Pontos>> ConsultarPontos(Motorista motorista);
    }
}

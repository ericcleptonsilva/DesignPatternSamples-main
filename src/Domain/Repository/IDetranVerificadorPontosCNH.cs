using System.Threading.Tasks;

namespace DesignPatternSamples.Domain.Repository.Detran
{
    public interface IDetranVerificadorPontosCNH
    {
        Task<Pontos> ConsultarPontos(Motorista motorista);
    }
}

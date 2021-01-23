using System;

namespace DesignPatternSamples.Application.Repository
{
    public interface IDetranVerificadorPontosCNHFactory
    {
        public IDetranVerificadorPontosCNHFactory Register(string CNH, Type repository);
        public IDetranVerificadorPontosCNHRepository Create(string CNH);
    }
}

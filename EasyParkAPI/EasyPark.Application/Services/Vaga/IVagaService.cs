using EasyPark.Core.Entities;

namespace EasyPark.Application.Services.Vaga
{
    public interface IVagaService
    {
        Task<IEnumerable<VagaModel>> GetVagasAsync();
    }
}

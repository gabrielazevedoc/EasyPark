using EasyParkAPI.Model;

namespace EasyParkAPI.Services.Vaga
{
    public interface IVagaService
    {
        Task<IEnumerable<VagaModel>> GetVagasAsync();
    }
}

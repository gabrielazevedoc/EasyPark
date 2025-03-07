using EasyParkAPI.InputModel;
using EasyParkAPI.Model;

namespace EasyParkAPI.Services.Carro
{
    public interface ICarroService
    {
        Task<CarroModel> AddCarroAsync(CarroModel carro);
        Task<IEnumerable<CarroModel>> GetCarrosByUsuarioIdAsync(int usuarioId);
    }
}

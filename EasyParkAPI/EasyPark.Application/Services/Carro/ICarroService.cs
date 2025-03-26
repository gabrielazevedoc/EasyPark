using EasyPark.Core.Entities;

namespace EasyPark.Application.Services.Carro
{
    public interface ICarroService
    {
        Task<CarroModel> AddCarroAsync(CarroModel carro);
        Task<IEnumerable<CarroModel>> GetCarrosByUsuarioIdAsync(int usuarioId);
    }
}

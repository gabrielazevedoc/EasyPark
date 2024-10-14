using System.ComponentModel.DataAnnotations;

namespace EasyParkAPI.Model
{
    public class CarroModel
    {

        [Key]
        public int Id { get;  private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
    }
}
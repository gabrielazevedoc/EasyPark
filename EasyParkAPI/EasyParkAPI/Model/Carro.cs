using System.ComponentModel.DataAnnotations;

namespace EasyParkAPI.Model
{
    public class Carro
    {
        public Carro(string modelo, string placa)
        {
            Modelo = modelo;
            Placa = placa;
        }

        [Key]
        public int IdCarro { get;  private set; }
        public string Modelo { get; private set; }
        public string Placa { get; private set; }
    }
}
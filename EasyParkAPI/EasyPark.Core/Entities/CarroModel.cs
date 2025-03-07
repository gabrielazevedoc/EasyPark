using EasyPark.Core.Entities;
using Microsoft.AspNetCore.Http;
using System.ComponentModel.DataAnnotations;
using System.ComponentModel.DataAnnotations.Schema;

namespace EasyPark.Core.Entities
{
    public class CarroModel: BaseEntity
    {
        public string Marca { get; set; }
        public string Modelo { get;  set; }
        public string Placa { get; set; }
        public string Cor { get; set; }
        [NotMapped]
        public IFormFile? Foto { get; set; }
    }
}
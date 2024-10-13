using System.ComponentModel.DataAnnotations;

namespace EasyParkAPI.Model
{
    public class Usuario
    {
        public Usuario(string nome, string cpf, string senha)
        {
            Nome = nome;
            Cpf = cpf;
            Senha = senha;
        }

        [Key]
        public int IdUsuario { get; set; }
        public string Nome { get; set; }
        public string Cpf { get; set; }
        public string Senha { get; set; }

        public List<Carro> Carros { get; set; }

       
    }
}

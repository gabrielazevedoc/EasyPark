using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class DisponibilildadeTests
    {
        [Fact]
        public void VerificarDisponibilidade_DeveRetornarVagasDisponiveis()
        {
            _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
            _sistema.ReservarVaga("ABC-1234");
            bool disponibilidade = _sistema.VerificarDisponibilidade();
            Assert.True(disponibilidade == true, "Disponibilidade de vagas não atualizada corretamente");
        }
    }
}
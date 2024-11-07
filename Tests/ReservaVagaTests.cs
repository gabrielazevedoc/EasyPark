using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class ReservaVagaTests
    {
        [Fact]
        public void ReservarVaga_DeveRetornarVerdadeiro_QuandoVagaEstiverDisponivel()
        {
            _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
            bool resultado = _sistema.ReservarVaga("ABC-1234");
            Assert.True(resultado, "Reserva de vaga falhou para uma vaga disponível");
        }

        [Fact]
        public void ReservarVaga_DeveRetornarFalso_QuandoVagaJaEstiverReservada()
        {
            _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
            _sistema.ReservarVaga("ABC-1234");
            bool resultado = _sistema.ReservarVaga("ABC-1234");
            Assert.False(resultado, "Sistema deveria bloquear reserva para vaga já ocupada");
        }
    }
}
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Xunit;

namespace Tests
{
    public class UsuarioTests
    {
        
    [Fact]
    public void CadastroUsuario_DeveRetornarVerdadeiro_QuandoCadastroForBemSucedido()
    {
        bool resultado = _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
        Assert.True(resultado, "Cadastro de usuário falhou");
    }

    [Fact]
    public void CadastroUsuario_DeveRetornarFalso_QuandoUsuarioJaExistente()
    {
        _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
        bool resultado = _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
        Assert.False(resultado, "Sistema deveria bloquear cadastro duplicado");
    }

    [Fact]
    public void LoginUsuario_DeveRetornarVerdadeiro_QuandoCredenciaisCorretas()
    {
        // Primeiro, cadastramos o usuário no sistema
        _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
        
        // Em seguida, tentamos realizar o login com as credenciais corretas
        bool loginResultado = _sistema.LoginUsuario("nome", "senha123");
        
        Assert.True(loginResultado, "Login falhou para credenciais corretas");
    }

    [Fact]
    public void LoginUsuario_DeveRetornarFalso_QuandoCredenciaisIncorretas()
    {
        // Primeiro, cadastramos o usuário no sistema
        _sistema.CadastrarUsuario("nome", "senha123", "ABC-1234", "Carro");
        
        // Tentativa de login com senha incorreta
        bool loginResultadoSenhaErrada = _sistema.LoginUsuario("nome", "senhaErrada");
        Assert.False(loginResultadoSenhaErrada, "Sistema deveria bloquear login com senha incorreta");

        // Tentativa de login com usuário inexistente
        bool loginResultadoUsuarioInexistente = _sistema.LoginUsuario("usuarioNaoExistente", "senha123");
        Assert.False(loginResultadoUsuarioInexistente, "Sistema deveria bloquear login para usuário inexistente");
    }

    }
}
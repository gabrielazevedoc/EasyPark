export class Usuario {
    id?: number; // Opcional, pois não será enviado no cadastro, mas será recebido da API
    nome: string;
    email: string;
    senha: string;
  
    constructor(nome: string, email: string, senha: string) {
      this.nome = nome;
      this.email = email;
      this.senha = senha;
    }
  }
  
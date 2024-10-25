import { Component } from '@angular/core';
import { CommonModule } from '@angular/common';
import { FormBuilder, FormControl, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { UsuarioService } from '../../Service/usuario.service';
import { Usuario } from '../../Models/Usuario';

@Component({
  selector: 'app-cadastro-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
  templateUrl: './cadastro-form.component.html',
  styleUrl: './cadastro-form.component.css'
})
export class CadastroFormComponent {


  cadastroForm!: FormGroup;

  constructor(private fb: FormBuilder, private usuarioService: UsuarioService) {}

  ngOnInit() {
    // Criando o formulário reativo com campos e validações
    this.cadastroForm = this.fb.group({
      nome: ['', [Validators.required, Validators.minLength(3)]],
      email: ['', [Validators.required, Validators.email]],
      dataNascimento: ['', Validators.required],
      senha: ['', [Validators.required, Validators.minLength(6)]]
    });
  }

  // Método que será chamado no submit do formulário
  onSubmit() {
    if (this.cadastroForm.valid) {
      //Pegando os valores do formulário
      const usuario = this.cadastroForm.value;

      // Chamando o Sserviço para cadastrar o usuário
      this.usuarioService.cadastrar(usuario).subscribe({
        next: (response: Usuario) => {
          alert("Usuario cadastrado com sucesso");
        },
        error: (error) => {
          alert("Erro no cadastramento do usuário")
        },
        complete: () => {
          console.log('Requisição completa');
        }})
      
    }
  }
}

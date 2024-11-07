import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { UsuarioService } from '../../Service/usuario.service';
import { Router, RouterModule } from '@angular/router';

@Component({
  selector: 'app-login-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule, RouterModule],
  templateUrl: './login-form.component.html',
  styleUrl: './login-form.component.css'
})
export class LoginFormComponent {
    loginForm: FormGroup;


    constructor(private fb: FormBuilder, private usuarioService : UsuarioService, private router: Router) {
      this.loginForm = this.fb.group({
        email: ['', [Validators.required, Validators.email]],
        senha: ['', [Validators.required, Validators.minLength(6)]]
      });
    }

    onSubmit() {
      if (this.loginForm.valid) {
        const loginData = {
          email: this.loginForm.value.email,
          senha: this.loginForm.value.senha
        };
    
        this.usuarioService.login(loginData).subscribe({
          next: (user) => {
            if (user) {
              this.router.navigate(['/reserva']);
              console.log(user);
            } else {
              // Exibir feedback visual para o usuário
              alert('Erro no login: usuário não encontrado ou credenciais inválidas.');
              this.loginForm.reset();

            }
          },
          error: (err) => {
            console.error('Erro de login:', err);
            // Exibir uma mensagem de erro visual para o usuário
            alert('Erro ao conectar com o servidor. Tente novamente mais tarde.');
          }
        });
      } else {
        console.warn('Formulário inválido');
        // Opcional: fornecer feedback visual para o usuário sobre formulário inválido
        alert('Por favor, preencha todos os campos corretamente.');
      }
    }
}

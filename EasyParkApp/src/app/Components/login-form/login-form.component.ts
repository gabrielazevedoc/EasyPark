import { CommonModule } from '@angular/common';
import { Component } from '@angular/core';
import { FormBuilder, FormGroup, ReactiveFormsModule, Validators } from '@angular/forms';
import { UsuarioService } from '../../Service/usuario.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-login-form',
  standalone: true,
  imports: [ReactiveFormsModule, CommonModule],
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
       

        console.log(loginData)

        this.usuarioService.login(loginData).subscribe({
          next: (user) => {
            if (user) {
              this.router.navigate(['/cadastro']);
              console.log(user)
            }
          },
          error: (err) => {
            console.error('Erro de login:', err);
          }
        });
      }
}
}

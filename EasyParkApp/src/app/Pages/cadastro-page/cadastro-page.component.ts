import { Component } from '@angular/core';
import { CadastroFormComponent } from "../../Components/cadastro-form/cadastro-form.component";
import { UsuarioService } from '../../Service/usuario.service';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-cadastro-page',
  standalone: true,
  imports: [CadastroFormComponent, MatIconModule],
  templateUrl: './cadastro-page.component.html',
  styleUrl: './cadastro-page.component.css'
})
export class CadastroPageComponent {
  constructor(private usuarioService: UsuarioService) {}

  logout() : void{
    this.usuarioService.logout();
  }
}

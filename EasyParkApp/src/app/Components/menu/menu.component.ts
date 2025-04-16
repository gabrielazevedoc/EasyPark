import { Component } from '@angular/core';
import { UsuarioService } from '../../Service/usuario.service';

@Component({
  selector: 'app-menu',
  standalone: true,
  imports: [],
  templateUrl: './menu.component.html',
  styleUrl: './menu.component.css'
})
export class MenuComponent {
  constructor(private usuarioService: UsuarioService) {}


  logout() : void{
    this.usuarioService.logout();
  }
}

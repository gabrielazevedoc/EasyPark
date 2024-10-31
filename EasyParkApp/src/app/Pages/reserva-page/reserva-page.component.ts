import { Component, OnInit } from '@angular/core';
import { ReservaFormComponent } from '../../Components/reserva-form/reserva-form.component';
import { VagasGridComponent } from '../../Components/vagas-grid/vagas-grid.component';
import { Usuario } from '../../Models/Usuario';
import { UsuarioService } from '../../Service/usuario.service';
import { CommonModule } from '@angular/common';
import { MatIconModule } from '@angular/material/icon';

@Component({
  selector: 'app-reserva-page',
  standalone: true,
  imports: [ReservaFormComponent, VagasGridComponent, CommonModule, MatIconModule],
  templateUrl: './reserva-page.component.html',
  styleUrl: './reserva-page.component.css'
})
export class ReservaPageComponent implements OnInit {
  usuario: Usuario | null = null;

  constructor(private usuarioService: UsuarioService) {}

  ngOnInit(): void {
    const userId = this.usuarioService.getLoggedInUserId();
    if (userId) {
      this.usuarioService.getUserInfo(userId).subscribe((user) => {
        this.usuario = user;
      });
    }
  }

  logout() : void{
    this.usuarioService.logout();
  }

}

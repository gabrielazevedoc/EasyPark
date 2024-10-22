import { Component } from '@angular/core';
import { VagasService } from '../../Service/vagas.service';
import { FormsModule } from '@angular/forms';

@Component({
  selector: 'app-reserva-form',
  standalone: true,
  templateUrl: './reserva-form.component.html',
  styleUrls: ['./reserva-form.component.css'],
  imports: [FormsModule]
})
export class ReservaFormComponent {
  nome: string = '';
  placa: string = '';
  modelo: string = '';
  vaga: number | null = null;

  constructor(private vagasService: VagasService) {}

  onSubmit() {
    if (this.vaga !== null) {
      this.vagasService.reservarVaga(this.vaga, {
        nome: this.nome,
        placa: this.placa,
        modelo: this.modelo
      });
    }
  }
}

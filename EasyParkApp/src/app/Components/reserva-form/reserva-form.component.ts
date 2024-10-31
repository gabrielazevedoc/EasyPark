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
  form = {
    nome: '',
    placa: '',
    modelo: '',
    numeroVaga: ''
  };

  constructor(private vagasService: VagasService) {
    this.vagasService.getSelectedSlot().subscribe(slotNumber => {
      if (slotNumber !== null) {
        this.form.numeroVaga = slotNumber.toString();
      }
    });
  }

  reservarVaga() {
    const slotNumber = parseInt(this.form.numeroVaga, 10);
    if (slotNumber && this.form.nome && this.form.placa && this.form.modelo) {
      this.vagasService.reserveSlot(slotNumber);
      this.limparFormulario();
    }
  }

  limparFormulario() {
    this.form = {
      nome: '',
      placa: '',
      modelo: '',
      numeroVaga: ''
    };
  }
}

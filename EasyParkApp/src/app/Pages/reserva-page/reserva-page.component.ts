import { Component } from '@angular/core';
import { ReservaFormComponent } from '../../Components/reserva-form/reserva-form.component';
import { VagasGridComponent } from '../../Components/vagas-grid/vagas-grid.component';

@Component({
  selector: 'app-reserva-page',
  standalone: true,
  imports: [ReservaFormComponent, VagasGridComponent],
  templateUrl: './reserva-page.component.html',
  styleUrl: './reserva-page.component.css'
})
export class ReservaPageComponent {

}

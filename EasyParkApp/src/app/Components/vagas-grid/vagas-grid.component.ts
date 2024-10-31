import { Component, OnInit } from '@angular/core';
import { VagasService } from '../../Service/vagas.service';
import { Slot } from '../../Service/vagas.service';
import { CommonModule } from '@angular/common';

@Component({
  selector: 'app-vagas-grid',
  standalone: true,
  templateUrl: './vagas-grid.component.html',
  styleUrls: ['./vagas-grid.component.css'],
  imports: [CommonModule]
})
export class VagasGridComponent implements OnInit {
  slots: Slot[] = [];

  constructor(private vagasService: VagasService) {}

  ngOnInit(): void {
    this.vagasService.getSlots().subscribe(slots => {
      this.slots = slots;
    });
  }

  selecionarVaga(slot: Slot) {
    if (!slot.reserved) {
      this.vagasService.selectSlot(slot.number);
    }
  }
}

import { Component, OnInit } from '@angular/core';
import { VagasService } from '../../Service/vagas.service';
import { NgFor } from '@angular/common';

@Component({
  selector: 'app-vagas-grid',
  standalone: true,
  templateUrl: './vagas-grid.component.html',
  styleUrls: ['./vagas-grid.component.css'],
  imports: [NgFor]
})
export class VagasGridComponent implements OnInit {
  vagas = Array.from({ length: 36 }, (_, i) => ({ numero: i + 1, reservada: false }));

  constructor(private vagasService: VagasService) {}

  ngOnInit() {
    this.vagasService.getVagas().subscribe(vagasAtualizadas => {
      this.vagas = vagasAtualizadas;
    });
  }

  selecionarVaga(vaga: any) {
    if (!vaga.reservada) {
      this.vagasService.selecionarVaga(vaga.numero);
    }
  }
}

import { Injectable } from '@angular/core';
import { BehaviorSubject } from 'rxjs';

interface Reserva {
  nome: string;
  placa: string;
  modelo: string;
}

@Injectable({
  providedIn: 'root'
})
export class VagasService {
  private vagas = new BehaviorSubject(
    Array.from({ length: 36 }, (_, i) => ({ numero: i + 1, reservada: false }))
  );
  vagas$ = this.vagas.asObservable();

  reservarVaga(vaga: number, reserva: Reserva) {
    const vagasAtualizadas = this.vagas.value.map(v => 
      v.numero === vaga ? { ...v, reservada: true, reserva } : v
    );
    this.vagas.next(vagasAtualizadas);
  }

  selecionarVaga(vaga: number) {
    console.log(`Vaga selecionada: ${vaga}`);
  }

  getVagas() {
    return this.vagas$;
  }
}

import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';

export interface Slot {
  number: number;
  reserved: boolean;
}

@Injectable({
  providedIn: 'root'
})
export class VagasService {
  private slots: Slot[] = Array.from({ length: 36 }, (_, i) => ({
    number: i + 1,
    reserved: false
  }));

  private selectedSlot = new BehaviorSubject<number | null>(null);
  private slotsSubject = new BehaviorSubject<Slot[]>(this.slots);

  getSlots(): Observable<Slot[]> {
    return this.slotsSubject.asObservable();
  }

  getSelectedSlot(): Observable<number | null> {
    return this.selectedSlot.asObservable();
  }

  selectSlot(slotNumber: number): void {
    this.selectedSlot.next(slotNumber);
  }

  reserveSlot(slotNumber: number): void {
    const slot = this.slots.find(s => s.number === slotNumber);
    if (slot) {
      slot.reserved = true;
      this.slotsSubject.next(this.slots);  // Atualiza a lista de vagas
      this.selectedSlot.next(null);  // Limpa a vaga selecionada
    }
  }
}
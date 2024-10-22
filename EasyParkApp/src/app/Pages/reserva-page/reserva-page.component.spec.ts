import { ComponentFixture, TestBed } from '@angular/core/testing';

import { ReservaPageComponent } from './reserva-page.component';

describe('ReservaPageComponent', () => {
  let component: ReservaPageComponent;
  let fixture: ComponentFixture<ReservaPageComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      imports: [ReservaPageComponent]
    })
    .compileComponents();

    fixture = TestBed.createComponent(ReservaPageComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

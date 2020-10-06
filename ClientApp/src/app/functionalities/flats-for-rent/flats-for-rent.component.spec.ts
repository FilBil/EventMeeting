import { ComponentFixture, TestBed } from '@angular/core/testing';

import { FlatsForRentComponent } from './flats-for-rent.component';

describe('FlatsForRentComponent', () => {
  let component: FlatsForRentComponent;
  let fixture: ComponentFixture<FlatsForRentComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ FlatsForRentComponent ]
    })
    .compileComponents();
  });

  beforeEach(() => {
    fixture = TestBed.createComponent(FlatsForRentComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { ComponentFixture, TestBed } from '@angular/core/testing';

import { DisplayGridDataComponent } from './display-grid-data.component';

describe('DisplayGridDataComponent', () => {
  let component: DisplayGridDataComponent;
  let fixture: ComponentFixture<DisplayGridDataComponent>;

  beforeEach(async () => {
    await TestBed.configureTestingModule({
      declarations: [ DisplayGridDataComponent ]
    })
    .compileComponents();

    fixture = TestBed.createComponent(DisplayGridDataComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

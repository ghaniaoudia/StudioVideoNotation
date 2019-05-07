import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { PrestationsListComponent } from './prestations-list.component';

describe('PrestationsListComponent', () => {
  let component: PrestationsListComponent;
  let fixture: ComponentFixture<PrestationsListComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ PrestationsListComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(PrestationsListComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

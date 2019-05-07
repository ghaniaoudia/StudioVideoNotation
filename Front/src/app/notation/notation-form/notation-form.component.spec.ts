import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NotationFormComponent } from './notation-form.component';

describe('NotationFormComponent', () => {
  let component: NotationFormComponent;
  let fixture: ComponentFixture<NotationFormComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NotationFormComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NotationFormComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

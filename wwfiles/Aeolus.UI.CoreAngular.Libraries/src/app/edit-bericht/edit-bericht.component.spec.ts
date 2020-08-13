import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditBerichtComponent } from './edit-bericht.component';

describe('EditBerichtComponent', () => {
  let component: EditBerichtComponent;
  let fixture: ComponentFixture<EditBerichtComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditBerichtComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditBerichtComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

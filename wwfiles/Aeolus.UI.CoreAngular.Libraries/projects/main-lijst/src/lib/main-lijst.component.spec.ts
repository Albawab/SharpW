import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { MainLijstComponent } from './main-lijst.component';

describe('MainLijstComponent', () => {
  let component: MainLijstComponent;
  let fixture: ComponentFixture<MainLijstComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ MainLijstComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(MainLijstComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

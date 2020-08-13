import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { ModulesMenuComponent } from './modules-menu.component';

describe('ModulesMenuComponent', () => {
  let component: ModulesMenuComponent;
  let fixture: ComponentFixture<ModulesMenuComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ ModulesMenuComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(ModulesMenuComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

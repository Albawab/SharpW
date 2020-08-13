import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigatorTestComponent } from './navigator-test.component';

describe('NavigatorTestComponent', () => {
  let component: NavigatorTestComponent;
  let fixture: ComponentFixture<NavigatorTestComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavigatorTestComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavigatorTestComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

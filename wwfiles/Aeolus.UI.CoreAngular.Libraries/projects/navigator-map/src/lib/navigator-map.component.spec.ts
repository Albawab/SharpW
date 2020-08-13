import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigatorMapComponent } from './navigator-map.component';

describe('NavigatorMapComponent', () => {
  let component: NavigatorMapComponent;
  let fixture: ComponentFixture<NavigatorMapComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavigatorMapComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavigatorMapComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

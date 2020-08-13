import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { NavigatorLijstItemsComponent } from './navigator-lijst-items.component';

describe('NavigatorLijstItemsComponent', () => {
  let component: NavigatorLijstItemsComponent;
  let fixture: ComponentFixture<NavigatorLijstItemsComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ NavigatorLijstItemsComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(NavigatorLijstItemsComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { RightSidebaarComponent } from './right-sidebaar.component';

describe('RightSidebaarComponent', () => {
  let component: RightSidebaarComponent;
  let fixture: ComponentFixture<RightSidebaarComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ RightSidebaarComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(RightSidebaarComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

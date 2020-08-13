import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { TestTxControlComponent } from './test-tx-control.component';

describe('TestTxControlComponent', () => {
  let component: TestTxControlComponent;
  let fixture: ComponentFixture<TestTxControlComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ TestTxControlComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(TestTxControlComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

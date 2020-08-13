import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { KlantPreviewComponent } from './klant-preview.component';

describe('KlantPreviewComponent', () => {
  let component: KlantPreviewComponent;
  let fixture: ComponentFixture<KlantPreviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ KlantPreviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(KlantPreviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

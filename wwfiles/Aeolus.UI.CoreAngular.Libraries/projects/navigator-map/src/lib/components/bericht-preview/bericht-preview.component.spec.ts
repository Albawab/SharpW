import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { BerichtPreviewComponent } from './bericht-preview.component';

describe('BerichtPreviewComponent', () => {
  let component: BerichtPreviewComponent;
  let fixture: ComponentFixture<BerichtPreviewComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ BerichtPreviewComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(BerichtPreviewComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

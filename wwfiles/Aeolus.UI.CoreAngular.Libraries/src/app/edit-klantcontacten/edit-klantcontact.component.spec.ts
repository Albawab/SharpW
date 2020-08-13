import { async, ComponentFixture, TestBed } from '@angular/core/testing';

import { EditKlantcontactComponent } from './edit-klantcontact.component';

describe('EditKlantcontactComponent', () => {
  let component: EditKlantcontactComponent;
  let fixture: ComponentFixture<EditKlantcontactComponent>;

  beforeEach(async(() => {
    TestBed.configureTestingModule({
      declarations: [ EditKlantcontactComponent ]
    })
    .compileComponents();
  }));

  beforeEach(() => {
    fixture = TestBed.createComponent(EditKlantcontactComponent);
    component = fixture.componentInstance;
    fixture.detectChanges();
  });

  it('should create', () => {
    expect(component).toBeTruthy();
  });
});

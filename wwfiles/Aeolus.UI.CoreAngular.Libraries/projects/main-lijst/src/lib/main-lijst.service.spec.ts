import { TestBed, inject } from '@angular/core/testing';

import { MainLijstService } from './main-lijst.service';

describe('MainLijstService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [MainLijstService]
    });
  });

  it('should be created', inject([MainLijstService], (service: MainLijstService) => {
    expect(service).toBeTruthy();
  }));
});

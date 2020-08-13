import { TestBed, inject } from '@angular/core/testing';

import { RightSidebaarService } from './right-sidebaar.service';

describe('RightSidebaarService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [RightSidebaarService]
    });
  });

  it('should be created', inject([RightSidebaarService], (service: RightSidebaarService) => {
    expect(service).toBeTruthy();
  }));
});

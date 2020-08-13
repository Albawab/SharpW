import { TestBed, inject } from '@angular/core/testing';

import { NavigatorMapService } from './navigator-map.service';

describe('NavigatorMapService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [NavigatorMapService]
    });
  });

  it('should be created', inject([NavigatorMapService], (service: NavigatorMapService) => {
    expect(service).toBeTruthy();
  }));
});

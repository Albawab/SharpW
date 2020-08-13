import { TestBed, inject } from '@angular/core/testing';

import { ModulesMenuService } from './modules-menu.service';

describe('ModulesMenuService', () => {
  beforeEach(() => {
    TestBed.configureTestingModule({
      providers: [ModulesMenuService]
    });
  });

  it('should be created', inject([ModulesMenuService], (service: ModulesMenuService) => {
    expect(service).toBeTruthy();
  }));
});

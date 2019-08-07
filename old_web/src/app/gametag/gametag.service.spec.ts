import { TestBed } from '@angular/core/testing';

import { GametagService } from './gametag.service';

describe('GametagService', () => {
  beforeEach(() => TestBed.configureTestingModule({}));

  it('should be created', () => {
    const service: GametagService = TestBed.get(GametagService);
    expect(service).toBeTruthy();
  });
});

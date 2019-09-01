import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GameDetails } from './model/GameDetails';
import { GameList } from './model/GameList';
import { BaseService } from '../shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class GameService extends BaseService<GameList, GameDetails> {

  constructor(
    http: HttpClient
  ) {
    super('games', http);
  }

}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { GameDetails } from './model/GameDetails';
import { GameList } from './model/GameList';
import { BaseService } from '../shared/base.service';
import { map } from 'rxjs/operators';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { GameEditForm } from './model/GameEditForm';

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

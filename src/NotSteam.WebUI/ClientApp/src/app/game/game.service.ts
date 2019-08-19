import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { BaseService } from '../shared/base-service';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { GameDetails } from './model/game-details';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';
import { GameList } from './model/game-list';

@Injectable({
  providedIn: 'root'
})
export class GameService extends BaseService {

  constructor(
    private http: HttpClient
  ) { 
    super('games');
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getPage(page = 1) {
    return this
      .http
      .get(this.getPageUrl(page))
      .pipe(
        map((raw: PaginationResponse<GameList>) => {
          return raw.response;
        })
      );
  }

  public getDropdown() {
    return this
      .http
      .get(this.getDropdownUrl());
  }

  public getOne(id) {
    return this
      .http
      .get(this.getOneUrl(id))
      .pipe(
        map((raw: DetailResponse<GameDetails>) => {
          return raw.response;
        })
      );
  }

  public deleteOne(gameId) {
    return this.http.delete(this.getOneUrl(gameId));
  }

  public addOne(game) {
    return this.http.post(this.getRootUrl(), game);
  }

  public putOne(gameId, game) {
    return this.http.put(this.getOneUrl(gameId), game);
  }

  public submit(game) {
    if (!game.id) {
      return this.addOne(game);
    }

    return this.putOne(game.id, game);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class GameService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly GAMES_URL = 'games';

  private getRootUrl() {
    return environment.apiUrl + this.GAMES_URL;
  }

  private formatUrl(gameId){
    return this.getRootUrl() + '/' + gameId;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getOne(gameId) {
    return this.http.get(this.formatUrl(gameId));
  }

  public deleteOne(gameId) {
    return this.http.delete(this.formatUrl(gameId));
  }

  public addOne(game) {
    return this.http.post(this.getRootUrl(), game);
  }

  public putOne(gameId, game) {
    return this.http.put(this.formatUrl(gameId), game);
  }

  public submit(game) {
    if(!game.id) {
      return this.addOne(game);
    }

    return this.putOne(game.id, game);
  }
}

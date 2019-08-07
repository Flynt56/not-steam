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

  public getAll() {
    return this.http.get(environment.apiUrl + this.GAMES_URL);
  }

  public getOne(gameId) {
    return this.http.get(environment.apiUrl + '/' + this.GAMES_URL + '/' + gameId);
  }

  public deleteOne(gameId) {
    return this.http.delete(environment.apiUrl + '/' + this.GAMES_URL + '/' + gameId);
  }

  public addOne(game) {
    return this.http.post(environment.apiUrl + '/' + this.GAMES_URL, game);
  }

  public putOne(gameId, game) {
    return this.http.put(environment.apiUrl + '/' + this.GAMES_URL + '/' + gameId, game);
  }
}

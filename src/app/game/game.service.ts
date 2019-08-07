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

  public deleteOne(gameId) {
    return this.http.delete(environment.apiUrl + this.GAMES_URL + '/' + gameId);
  }
}

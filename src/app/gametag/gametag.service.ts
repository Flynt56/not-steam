import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class GametagService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly GAMETAGS_URL = 'gametags';

  public getAll() {
    return this.http.get(environment.apiUrl + this.GAMETAGS_URL);
  }

  public getOne(gameId, tagId) {
    return this.http.get(environment.apiUrl + '/' + this.GAMETAGS_URL + '/' + gameId + '/' + tagId);
  }

  public deleteOne(gameId, tagId) {
    return this.http.delete(environment.apiUrl + '/' + this.GAMETAGS_URL + '/' + gameId + '/' + tagId);
  }

  public addOne(gameTag) {
    return this.http.post(environment.apiUrl + '/' + this.GAMETAGS_URL, gameTag);
  }

  public putOne(gameId, tagId, gameTag) {
    return this.http.put(environment.apiUrl + '/' + this.GAMETAGS_URL + '/' + gameId + '/' + tagId, gameTag);
  }
}

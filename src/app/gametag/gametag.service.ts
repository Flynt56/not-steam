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

  private getRootUrl() {
    return environment.apiUrl + '/' + this.GAMETAGS_URL;
  }

  private formatUrl(gameId, tagId){
    return this.getRootUrl() + '/' + gameId + '/' + tagId;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getOne(gameId, tagId) {
    return this.http.get(this.formatUrl(gameId, tagId));
  }

  public deleteOne(gameId, tagId) {
    return this.http.delete(this.formatUrl(gameId, tagId));
  }

  public addOne(gameTag) {
    return this.http.post(this.getRootUrl(), gameTag);
  }

  public putOne(gameId, tagId, gameTag) {
    return this.http.put(this.formatUrl(gameId, tagId), gameTag);
  }
}

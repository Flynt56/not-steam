import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LibraryService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly LIBRARIES_URL = 'libraries';

  private getRootUrl() {
    return environment.apiUrl + '/' + this.LIBRARIES_URL;
  }

  private formatUrl(userId, gameId){
    return this.getRootUrl() + '/' + userId + '/' + gameId;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getOne(userId, gameId) {
    return this.http.get(this.formatUrl(userId, gameId));
  }

  public deleteOne(userId, gameId) {
    return this.http.delete(this.formatUrl(userId, gameId));
  }

  public addOne(library) {
    return this.http.post(this.getRootUrl(), library);
  }

  public putOne(userId, gameId, library) {
    return this.http.put(this.formatUrl(userId, gameId), library);
  }
}

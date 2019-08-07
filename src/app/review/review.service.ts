import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class ReviewService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly REVIEWS_URL = 'reviews';

  private getRootUrl() {
    return environment.apiUrl + this.REVIEWS_URL;
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

  public addOne(review) {
    return this.http.post(this.getRootUrl(), review);
  }

  public putOne(userId, gameId, review) {
    return this.http.put(this.formatUrl(userId, gameId), review);
  }
}

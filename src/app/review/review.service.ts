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

  public getAll() {
    return this.http.get(environment.apiUrl + this.REVIEWS_URL);
  }

  public getOne(reviewId) {
    return this.http.get(environment.apiUrl + '/' + this.REVIEWS_URL + '/' + reviewId);
  }

  public deleteOne(reviewId) {
    return this.http.delete(environment.apiUrl + '/' + this.REVIEWS_URL + '/' + reviewId);
  }

  public addOne(review) {
    return this.http.post(environment.apiUrl + '/' + this.REVIEWS_URL, review);
  }

  public putOne(reviewId, review) {
    return this.http.put(environment.apiUrl + '/' + this.REVIEWS_URL + '/' + reviewId, review);
  }
}

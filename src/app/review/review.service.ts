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
}

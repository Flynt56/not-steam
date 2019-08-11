import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class PurchaseService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly PURCHASES_URL = 'purchases';

  private getRootUrl() {
    return environment.apiUrl + this.PURCHASES_URL;
  }

  private formatUrl(userId, gameId) {
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

  public addOne(purchase) {
    return this.http.post(this.getRootUrl(), purchase);
  }

  public putOne(userId, gameId, purchase) {
    return this.http.put(this.formatUrl(userId, gameId), purchase);
  }

  public submit(purchase) {
    return this.putOne(purchase.userId, purchase.gameId, purchase);
  }

  public submitNew(purchase) {
    return this.addOne(purchase);
  }
}

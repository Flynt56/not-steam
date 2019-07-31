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

  public getAll() {
    return this.http.get(environment.apiUrl + this.PURCHASES_URL);
  }
}

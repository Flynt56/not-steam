import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class UserService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly USERS_URL = 'users';

  public getAll() {
    return this.http.get(environment.apiUrl + this.USERS_URL);
  }

  public getOne(id: number) {
    return this.http.get(environment.apiUrl + this.USERS_URL + '/' + id);
  }

  public post(item: any) {
    return this.http.post(environment.apiUrl + this.USERS_URL, item);
  }

  public put(id: number, item: any) {
    return this.http.put(environment.apiUrl + this.USERS_URL + '/' + id, item);
  }

  public delete(id: number) {
    return this.http.delete(environment.apiUrl + this.USERS_URL + '/' + id);
  }
}

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
}

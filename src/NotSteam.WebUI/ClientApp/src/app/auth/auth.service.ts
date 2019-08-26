import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { Login } from './login/login';
import { Register } from './register/register';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(
    private http: HttpClient
  ) { }

  public register(data: Register) {
    return this.http.post(environment.apiUrl + 'auth/register', data);
  }

  public login(data: Login) {
    return this.http.post(environment.apiUrl + 'auth/login', data);
  }

}

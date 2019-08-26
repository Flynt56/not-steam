import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { Login } from './login/login';
import { environment } from 'src/environments/environment';
import { Register } from './register/register';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(
    private http: HttpClient
  ) { }

  public login(data: Login) {
    return this.http.post(environment.apiUrl + 'auth/login', data);
  }

  public register(data: Register) {
    return this.http.post(environment.apiUrl + 'auth/register', data);
  }

}

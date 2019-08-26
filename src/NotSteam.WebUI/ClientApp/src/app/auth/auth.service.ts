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

  private rootAuth = 'auth';
  private loginRoute = 'login';
  private registerRoute = 'register';

  public login(data: Login) {
    return this.http.post(`${environment.apiUrl}${this.rootAuth}/${this.loginRoute}`, data);
  }

  public register(data: Register) {
    return this.http.post(`${environment.apiUrl}${this.rootAuth}/${this.registerRoute}`, data);
  }

}

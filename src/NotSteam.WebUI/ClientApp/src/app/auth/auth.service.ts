import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
<<<<<<< HEAD
import { environment } from 'src/environments/environment';
import { Login } from './login/login';
=======
import { Login } from './login/login';
import { environment } from 'src/environments/environment';
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85
import { Register } from './register/register';

@Injectable({
  providedIn: 'root'
})
export class AuthService {

  constructor(
    private http: HttpClient
  ) { }

<<<<<<< HEAD
  public register(data: Register) {
    return this.http.post(environment.apiUrl + 'auth/register', data);
  }

=======
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85
  public login(data: Login) {
    return this.http.post(environment.apiUrl + 'auth/login', data);
  }

<<<<<<< HEAD
=======
  public register(data: Register) {
    return this.http.post(environment.apiUrl + 'auth/register', data);
  }

>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85
}

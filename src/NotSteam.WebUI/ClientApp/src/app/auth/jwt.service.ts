import { Injectable } from '@angular/core';

@Injectable({
  providedIn: 'root'
})
export class JwtService {

  private readonly TOKEN_KEY = 'token';
  private readonly USER_KEY = 'auth_user';

  constructor() { }

  public getToken() {
    return localStorage.getItem(this.TOKEN_KEY);
  }

  public setToken(token: string) {
    localStorage.setItem(this.TOKEN_KEY, token);
  }

  public setUser(user = {}) {
    localStorage.setItem(this.USER_KEY, JSON.stringify(user));
  }

  public updateUserAuth(token: string, user = {}) {
    this.setToken(token);
    this.setUser(user);
  }

  public getUser() {
    return JSON.parse(localStorage.getItem(this.USER_KEY));
  }

  public isLoggedIn() {
    const token = this.getToken();

    return token && token.length > 0;
  }

  public getFullToken() {
    return `Bearer ${this.getToken()}`;
  }

  public logout() {
    this.setUser();
    this.setToken('');
  }

}

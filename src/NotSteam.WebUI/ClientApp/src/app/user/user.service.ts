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

  private getRootUrl() {
    return environment.apiUrl + this.USERS_URL;
  }

  private formatUrl(userId){
    return this.getRootUrl() + '/' + userId;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getOne(userId) {
    return this.http.get(this.formatUrl(userId));
  }

  public deleteOne(userId) {
    return this.http.delete(this.formatUrl(userId));
  }

  public addOne(user) {
    return this.http.post(this.getRootUrl(), user);
  }

  public putOne(userId, user) {
    return this.http.put(this.formatUrl(userId), user);
  }
}

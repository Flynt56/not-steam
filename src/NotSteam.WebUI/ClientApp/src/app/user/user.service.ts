import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';
import { UserDetails } from './model/user-details';
import { UserList } from './model/user-list';

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

  private formatUrl(id) {
    return this.getRootUrl() + '/' + id;
  }

  private formatPageUrl(page) {
    return this.getRootUrl() + '?page=' + page;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getPage(page = 1) {
    return this
      .http
      .get(this.formatPageUrl(page))
      .pipe(
        map((raw: PaginationResponse<UserList>) => {
          return raw.response;
        })
      );
  }

  public getDropdown() {
    return this
      .http
      .get(this.getRootUrl() + '/dropdown');
  }

  public getOne(id) {
    return this
      .http
      .get(this.formatUrl(id))
      .pipe(
        map((raw: DetailResponse<UserDetails>) => {
          return raw.response;
        })
      );
  }

  public deleteOne(id) {
    return this.http.delete(this.formatUrl(id));
  }

  public addOne(user) {
    return this.http.post(this.getRootUrl(), user);
  }

  public putOne(id, user) {
    return this.http.put(this.formatUrl(id), user);
  }

  public submit(user) {
    if (!user.id) {
      return this.addOne(user);
    }

    return this.putOne(user.id, user);
  }
}

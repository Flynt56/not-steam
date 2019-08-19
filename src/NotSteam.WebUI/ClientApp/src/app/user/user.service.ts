import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';
import { UserDetails } from './model/user-details';
import { UserList } from './model/user-list';
import { BaseService } from '../shared/base-service';

@Injectable({
  providedIn: 'root'
})
export class UserService extends BaseService {

  constructor(
    private http: HttpClient
  ) {
    super('users');
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getPage(page = 1) {
    return this
      .http
      .get(this.getPageUrl(page))
      .pipe(
        map((raw: PaginationResponse<UserList>) => {
          return raw.response;
        })
      );
  }

  public getDropdown() {
    return this
      .http
      .get(this.getDropdownUrl());
  }

  public getOne(id) {
    return this
      .http
      .get(this.getOneUrl(id))
      .pipe(
        map((raw: DetailResponse<UserDetails>) => {
          return raw.response;
        })
      );
  }

  public deleteOne(id) {
    return this.http.delete(this.getOneUrl(id));
  }

  public addOne(user) {
    return this.http.post(this.getRootUrl(), user);
  }

  public putOne(id, user) {
    return this.http.put(this.getOneUrl(id), user);
  }

  public submit(user) {
    if (!user.id) {
      return this.addOne(user);
    }

    return this.putOne(user.id, user);
  }
}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { UserDetails } from './model/UserDetails';
import { UserList } from './model/UserList';
import { BaseService } from '../shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class UserService extends BaseService<UserList, UserDetails> {

  constructor(
    http: HttpClient
  ) {
    super('users', http);
  }

}

import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { CompanyList } from './model/CompanyList';
import { CompanyDetails } from './model/CompanyDetails';
import { BaseService } from '../shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class CompanyService extends BaseService<CompanyList, CompanyDetails> {

  constructor(
    http: HttpClient
  ) {
    super('companies', http);
  }
}

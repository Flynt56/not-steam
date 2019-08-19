import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { BaseService } from '../shared/base-service';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';

@Injectable({
  providedIn: 'root'
})
export class CompanyService extends BaseService {

  constructor(
    private http: HttpClient
  ) {
    super('companies');
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

  public deleteOne(companyId) {
    return this.http.delete(this.getOneUrl(companyId));
  }

  public addOne(company) {
    return this.http.post(this.getRootUrl(), company);
  }

  public putOne(companyId, company) {
    return this.http.put(this.getOneUrl(companyId), company);
  }

  public submit(company) {
    if (!company.id) {
      return this.addOne(company);
    }

    return this.putOne(company.id, company);
  }
}

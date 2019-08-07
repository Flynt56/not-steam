import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class CompanyService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly COMPANIES_URL = 'companies';

  private getRootUrl() {
    return environment.apiUrl + this.COMPANIES_URL;
  }

  private formatUrl(companyId){
    return this.getRootUrl() + '/' + companyId;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getOne(companyId) {
    return this.http.get(this.formatUrl(companyId));
  }

  public deleteOne(companyId) {
    return this.http.delete(this.formatUrl(companyId));
  }

  public addOne(company) {
    return this.http.post(this.getRootUrl(), company);
  }

  public putOne(companyId, company) {
    return this.http.put(this.formatUrl(companyId), company);
  }
}

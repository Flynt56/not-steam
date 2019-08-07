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

  public getAll() {
    return this.http.get(environment.apiUrl + this.COMPANIES_URL);
  }

  public getOne(gameId){
    return this.http.get(environment.apiUrl + this.COMPANIES_URL + '/' + gameId);
  }
}

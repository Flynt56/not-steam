import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class LibraryService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly LIBRARIES_URL = 'libraries';

  public getAll() {
    return this.http.get(environment.apiUrl + this.LIBRARIES_URL);
  }
}

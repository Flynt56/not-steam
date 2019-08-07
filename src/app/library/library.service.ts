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

  public getOne(libraryId) {
    return this.http.get(environment.apiUrl + '/' + this.LIBRARIES_URL + '/' + libraryId);
  }

  public deleteOne(libraryId) {
    return this.http.delete(environment.apiUrl + '/' + this.LIBRARIES_URL + '/' + libraryId);
  }

  public addOne(library) {
    return this.http.post(environment.apiUrl + '/' + this.LIBRARIES_URL, library);
  }

  public putOne(libraryId, library) {
    return this.http.put(environment.apiUrl + '/' + this.LIBRARIES_URL + '/' + libraryId, library);
  }
}

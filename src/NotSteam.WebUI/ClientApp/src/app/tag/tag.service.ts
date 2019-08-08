import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';

@Injectable({
  providedIn: 'root'
})
export class TagService {

  constructor(
    private http: HttpClient
  ) { }

  private readonly TAGS_URL = 'tags';

  private getRootUrl() {
    return environment.apiUrl + this.TAGS_URL;
  }

  private formatUrl(tagId) {
    return this.getRootUrl() + '/' + tagId;
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getOne(tagId) {
    return this.http.get(this.formatUrl(tagId));
  }

  public deleteOne(tagId) {
    return this.http.delete(this.formatUrl(tagId));
  }

  public addOne(tag) {
    return this.http.post(this.getRootUrl(), tag);
  }

  public putOne(tagId, tag) {
    return this.http.put(this.formatUrl(tagId), tag);
  }

  public submit(tag) {
    if (!tag.id) {
      return this.addOne(tag);
    }

    return this.putOne(tag.id, tag);
  }
}

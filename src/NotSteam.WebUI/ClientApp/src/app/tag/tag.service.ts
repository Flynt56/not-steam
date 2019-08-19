import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { environment } from 'src/environments/environment';
import { TagList } from './model/tag-list';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { TagDetails } from './model/tag-details';

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
        map((raw: PaginationResponse<TagList>) => {
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
        map((raw: DetailResponse<TagDetails>) => {
          return raw.response;
        })
      );
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

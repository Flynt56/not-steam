import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TagList } from './model/tag-list';
import { map } from 'rxjs/operators';
import { PaginationResponse } from '../shared/Response/PaginationResponse';
import { DetailResponse } from '../shared/Response/DetailResponse';
import { TagDetails } from './model/tag-details';
import { BaseService } from '../shared/base-service';

@Injectable({
  providedIn: 'root'
})
export class TagService extends BaseService {

  constructor(
    private http: HttpClient
  ) {
    super('tags');
  }

  public getAll() {
    return this.http.get(this.getRootUrl());
  }

  public getPage(page = 1) {
    return this
      .http
      .get(this.getPageUrl(page))
      .pipe(
        map((raw: PaginationResponse<TagList>) => {
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
        map((raw: DetailResponse<TagDetails>) => {
          return raw.response;
        })
      );
  }

  public deleteOne(tagId) {
    return this.http.delete(this.getOneUrl(tagId));
  }

  public addOne(tag) {
    return this.http.post(this.getRootUrl(), tag);
  }

  public putOne(tagId, tag) {
    return this.http.put(this.getOneUrl(tagId), tag);
  }

  public submit(tag) {
    if (!tag.id) {
      return this.addOne(tag);
    }

    return this.putOne(tag.id, tag);
  }
}

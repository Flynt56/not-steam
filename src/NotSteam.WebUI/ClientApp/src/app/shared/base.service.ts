import { Injectable } from '@angular/core';
import { environment } from 'src/environments/environment';
import { HttpClient } from '@angular/common/http';
import { DetailResponse } from './Response/DetailResponse';
import { PaginationResponse } from './Response/PaginationResponse';
import { map } from 'rxjs/operators';

@Injectable({
  providedIn: 'root'
})
export class BaseService<TPaginationResponse, TDetailResponse> {

  constructor(
    protected routeUrl: string,
    protected http: HttpClient
  ) { }

  protected getRootUrl(): string {
    return `${environment.apiUrl}${this.routeUrl}`;
  }

  protected getPageUrl(page: any): string {
    return `${this.getRootUrl()}?page=${page}`;
  }

  protected getOneUrl(id: number): string {
    return `${this.getRootUrl()}/${id}`;
  }

  protected getAddFormUrl(): string {
    return `${this.getRootUrl()}/add`;
  }

  protected getEditFormUrl(id: number): string {
    return `${this.getRootUrl()}/edit/${id}`;
  }

  protected getOneArrayUrl(id: Array<number>): string {
    return this.getRootUrl() + Array.from(id).map((item: any) => '/' + item);
  }

  public getAll() {
    return this
      .http
      .get(this.getRootUrl());
  }

  public getPage(page = 1) {
    return this
      .http
      .get(this.getPageUrl(page))
      .pipe(
        map((raw: PaginationResponse<TPaginationResponse>) => {
          return raw.response;
        })
      );
  }

  public getAddForm<TAddForm>() {
    return this
      .http
      .get(this.getAddFormUrl())
      .pipe(
        map((raw: DetailResponse<TAddForm>) => {
          return raw.response;
        })
      );
  }

  public getEditFormById<TEditForm>(id: number) {
    return this
      .http
      .get(this.getEditFormUrl(id))
      .pipe(
        map((raw: DetailResponse<TEditForm>) => {
          return raw.response;
        })
      );
  }

  public getOneById(id: number) {
    return this
      .http
      .get(this.getOneUrl(id))
      .pipe(
        map((raw: DetailResponse<TDetailResponse>) => {
          return raw.response;
        })
      );
  }

  public getOneByIds(id: Array<any>) {
    return this
      .http
      .get(this.getOneArrayUrl(id))
      .pipe(
        map((raw: DetailResponse<TDetailResponse>) => {
          return raw.response;
        })
      );
  }

  public deleteOneById(id: number) {
    return this
      .http
      .delete(this.getOneUrl(id));
  }

  public deleteOneByIds(id: Array<number>) {
    return this
      .http
      .delete(this.getOneArrayUrl(id));
  }

  public addOne(item: any) {
    return this
      .http
      .post(this.getRootUrl(), item);
  }

  public putOneById(id: number, item: any) {
    return this
      .http
      .put(this.getOneUrl(id), item);
  }

  public putOneByIds(id: Array<number>, item: any) {
    return this
      .http
      .put(this.getOneArrayUrl(id), item);
  }

  public submit(item: any) {
    if (item.id) {
      return this.putOneById(item.id, item);
    }

    return this.addOne(item);
  }

  public submitComposite(id: Array<number>, item: any) {
    if (id && id.length && id.every((element: any) => element !== undefined)) {
      return this.putOneByIds(id, item);
    }

    return this.addOne(item);
  }

}

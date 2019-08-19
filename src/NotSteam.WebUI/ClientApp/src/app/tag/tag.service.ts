import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { TagList } from './model/TagList';
import { TagDetails } from './model/TagDetails';
import { BaseService } from '../shared/base.service';

@Injectable({
  providedIn: 'root'
})
export class TagService extends BaseService<TagList, TagDetails> {

  constructor(
    http: HttpClient
  ) {
    super('tags', http);
  }

}

import { Component, OnInit } from '@angular/core';
import { TagService } from '../tag.service';

@Component({
  selector: 'app-tag-list',
  templateUrl: './tag-list.component.html',
  styleUrls: ['./tag-list.component.scss']
})
export class TagListComponent implements OnInit {

  constructor(
    private tagService: TagService
  ) { }

  private tags = []

  ngOnInit() {
    this.tagService.getAll().subscribe((response: any) => {
      this.tags = response;
    })
  }

}

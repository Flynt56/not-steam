import { Component, OnInit } from '@angular/core';
import { TagService } from '../tag.service';
import { Router } from '@angular/router';
import { TagList } from '../model/tag-list';
import { CommonService } from 'src/app/shared/common.service';
import { Pagination } from 'src/app/shared/Response/Pagination';

@Component({
  selector: 'app-tag-list',
  templateUrl: './tag-list.component.html',
  styleUrls: ['./tag-list.component.scss']
})
export class TagListComponent implements OnInit {

  constructor(
    private tagService: TagService,
    private router: Router,
    private common: CommonService
  ) { }

  private tags = Array<TagList>();
  private pagination: Pagination;

  ngOnInit() {
    this.getAllTags();
  }

  getAllTags() {
    this.tagService
    .getPage(1)
    .subscribe(({ data, pagination }) => {
      this.pagination = pagination;
      this.tags = data;
      this.common.hide();
    });
  }

  onDelete(tagId) {
    if (confirm('Jeste li sigurni?')) {
      this.tagService.deleteOne(tagId).subscribe(result => {
        this.getAllTags();
        this.common.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['tags/new']);
  }

  onEdit(tagId) {
    this.common.show();
    this.router.navigate(['tags', tagId]);
  }

}

import { Component, OnInit } from '@angular/core';
import { TagService } from '../tag.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-tag-list',
  templateUrl: './tag-list.component.html',
  styleUrls: ['./tag-list.component.scss']
})
export class TagListComponent implements OnInit {

  constructor(
    private tagService: TagService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private tags = [];

  ngOnInit() {
    this.getAllTags();
  }

  getAllTags() {
    this.tagService.getAll().subscribe((response: any) => {
      this.tags = response;
    });
  }

  onDelete(tagId) {
    if (confirm('Jeste li sigurni?')) {
      this.tagService.deleteOne(tagId).subscribe(result => {
        this.getAllTags();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['tags/new']);
  }

  onEdit(tagId) {
    this.spinner.show();
    this.router.navigate(['tags', tagId]);
  }

}

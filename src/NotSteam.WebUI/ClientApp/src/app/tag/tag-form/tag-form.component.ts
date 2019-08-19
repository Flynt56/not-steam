import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TagService } from '../tag.service';
import { CommonService } from 'src/app/shared/common.service';
import { TagDetails } from '../model/TagDetails';

@Component({
  selector: 'app-tag-form',
  templateUrl: './tag-form.component.html',
  styleUrls: ['./tag-form.component.scss']
})
export class TagFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private tagService: TagService,
    private router: Router,
    private common: CommonService
  ) { }

  public tag: TagDetails = new TagDetails();
  public errorMessage = '';

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const tagId = params.get('id');

      if (tagId != null) {
        this.getTag(tagId);
      }
    });
  }

  getTag(tagId) {
    this.tagService.getOneById(tagId).subscribe(response => {
      this.tag = response;
      this.common.hide();
    });
  }

  onSubmit() {
    this.common.show();

    this.tagService.submit(this.tag).subscribe(
      () => {
        this.common.success('Uspješno izvršeno!');
        this.router.navigate(['tags']);
        this.common.hide();
      },
      (response: any) => {
        const firstError = response.error.errors;
        const firstKey = Object.keys(firstError)[0];
        this.errorMessage = firstError[firstKey][0];
        this.common.hide();
      });
  }

}

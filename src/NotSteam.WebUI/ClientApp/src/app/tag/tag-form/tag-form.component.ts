import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { TagService } from '../tag.service';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-tag-form',
  templateUrl: './tag-form.component.html',
  styleUrls: ['./tag-form.component.scss']
})
export class TagFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private tagService: TagService,
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService
  ) { }

  public tag: any = {};
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
    this.tagService.getOne(tagId).subscribe(response => {
      this.tag = response;
      this.spinner.hide();
    });
  }

  onSubmit() {
    this.spinner.show();

    this.tagService.submit(this.tag).subscribe(
      () => {
        this.toastr.success('Uspješno izvršeno!');
        this.router.navigate(['tags']);
        this.spinner.hide();
      },
      (response: any) => {
        const firstError = response.error.errors;
        const firstKey = Object.keys(firstError)[0];
        this.errorMessage = firstError[firstKey][0];
        this.spinner.hide();
      });
  }

}

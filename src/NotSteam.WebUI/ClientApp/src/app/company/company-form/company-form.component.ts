import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../company.service';
import { ActivatedRoute, Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';

@Component({
  selector: 'app-company-form',
  templateUrl: './company-form.component.html',
  styleUrls: ['./company-form.component.scss']
})
export class CompanyFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private companyService: CompanyService,
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService,
  ) { }

  private company: any = {};
  private errorMessage = "";

  ngOnInit() {
    this.route.params.subscribe(params => {
      const companyId = params['id'];

      if (companyId != null) {
        this.getCompany(companyId);
      }
    })
  }

  getCompany(companyId) {
    this.companyService.getOne(companyId).subscribe(response => {
      this.company = response;
      this.spinner.hide();
    });
  }

  onSubmit() {
    this.spinner.show();

    this.companyService.submit(this.company).subscribe(
      (response: any) => {
        this.toastr.success('Uspješno izvršeno!');
        this.router.navigate(['companies']);
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

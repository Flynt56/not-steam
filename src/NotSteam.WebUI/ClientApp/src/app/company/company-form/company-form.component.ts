import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../company.service';
import { ActivatedRoute, Router } from '@angular/router';
import { CommonService } from 'src/app/shared/common.service';
import { CompanyDetails } from '../model/CompanyDetails';

@Component({
  selector: 'app-company-form',
  templateUrl: './company-form.component.html',
  styleUrls: ['./company-form.component.scss']
})
export class CompanyFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private companyService: CompanyService,
    private common: CommonService,
    private router: Router
  ) { }

  private company: CompanyDetails = new CompanyDetails();
  private errorMessage = '';

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const companyId = params.get('id');

      if (companyId != null) {
        this.getCompany(companyId);
      }
    });
  }

  getCompany(companyId) {
    this.companyService.getOneById(companyId).subscribe(response => {
      this.company = response;
      this.common.hide();
    });
  }

  onSubmit() {
    this.common.show();

    this.companyService.submit(this.company).subscribe(
      () => {
        this.common.success('Uspješno izvršeno!');
        this.router.navigate(['companies']);
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

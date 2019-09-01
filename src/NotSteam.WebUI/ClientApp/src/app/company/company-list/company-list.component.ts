import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../company.service';
import { Router } from '@angular/router';
import { CommonService } from 'src/app/shared/common.service';
import { CompanyList } from '../model/CompanyList';
import { Pagination } from 'src/app/shared/Response/Pagination';

@Component({
  selector: 'app-company-list',
  templateUrl: './company-list.component.html',
  styleUrls: ['./company-list.component.scss']
})
export class CompanyListComponent implements OnInit {

  constructor(
    private companyService: CompanyService,
    private router: Router,
    private common: CommonService
  ) { }

  private companies = Array<CompanyList>();
  private pagination: Pagination;

  ngOnInit() {
    this.getAllCompanies();
  }

  getAllCompanies() {
    this.companyService
      .getPage(1)
      .subscribe(({ data, pagination }) => {
        this.pagination = pagination;
        this.companies = data;
        this.common.hide();
      });
  }

  onDelete(companyId) {
    if (confirm('Jeste li sigurni?')) {
      this.companyService.deleteOneById(companyId).subscribe(result => {
        this.getAllCompanies();
        this.common.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['companies', 'new']);
  }

  onEdit(companyId) {
    this.common.show();
    this.router.navigate(['companies', 'edit', companyId]);
  }

}

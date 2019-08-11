import { Component, OnInit } from '@angular/core';
import { CompanyService } from '../company.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-company-list',
  templateUrl: './company-list.component.html',
  styleUrls: ['./company-list.component.scss']
})
export class CompanyListComponent implements OnInit {

  constructor(
    private companyService: CompanyService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private companies = [];

  ngOnInit() {
    this.getAllCompanies();
  }

  getAllCompanies() {
    this.companyService.getAll().subscribe((response: any) => {
      this.companies = response;
    });
  }

  onAdd() {
    this.router.navigate(['companies/new']);
  }

  onEdit(companyId) {
    this.spinner.show();
    this.router.navigate(['companies', companyId]);
  }

  onDelete(companyId) {
    if (confirm('Jeste li sigurni?')) {
      this.companyService.deleteOne(companyId).subscribe(result => {
        this.getAllCompanies();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }
}

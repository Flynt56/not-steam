import { Component, OnInit } from '@angular/core';
import { PurchaseService } from '../purchase.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-purchase-list',
  templateUrl: './purchase-list.component.html',
  styleUrls: ['./purchase-list.component.scss']
})
export class PurchaseListComponent implements OnInit {

  constructor(
    private purchaseService: PurchaseService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private purchases = [];

  ngOnInit() {
    this.getAllPurchases();
  }

  getAllPurchases() {
    this.purchaseService.getAll().subscribe((response: any) => {
      this.purchases = response;
    });
  }

  onDelete(userId, gameId) {
    if (confirm('Jeste li sigurni?')) {
      this.purchaseService.deleteOne(userId, gameId).subscribe(result => {
        this.getAllPurchases();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['purchases/new']);
  }

  onEdit(userId, gameId) {
    this.spinner.show();
    this.router.navigate(['purchases', userId, gameId]);
  }
}

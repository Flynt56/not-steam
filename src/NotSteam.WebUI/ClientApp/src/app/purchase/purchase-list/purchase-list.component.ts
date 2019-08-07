import { Component, OnInit } from '@angular/core';
import { PurchaseService } from '../purchase.service';

@Component({
  selector: 'app-purchase-list',
  templateUrl: './purchase-list.component.html',
  styleUrls: ['./purchase-list.component.scss']
})
export class PurchaseListComponent implements OnInit {

  constructor(
    private purchaseService: PurchaseService
  ) { }

  private purchases = [];

  ngOnInit() {
    this.purchaseService.getAll().subscribe((response: any) => {
      this.purchases = response;
    });
  }

}

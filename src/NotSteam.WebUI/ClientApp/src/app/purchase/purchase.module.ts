import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { PurchaseRoutingModule } from './purchase-routing.module';
import { PurchaseListComponent } from './purchase-list/purchase-list.component';
import { PurchaseFormComponent } from './purchase-form/purchase-form.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [PurchaseListComponent, PurchaseFormComponent],
  imports: [
    CommonModule,
    PurchaseRoutingModule,
    FormsModule,
    BrowserAnimationsModule
  ]
})
export class PurchaseModule { }

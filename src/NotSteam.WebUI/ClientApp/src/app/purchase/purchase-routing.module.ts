import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { PurchaseListComponent } from './purchase-list/purchase-list.component';
import { PurchaseFormComponent } from './purchase-form/purchase-form.component';


const routes: Routes = [
  { path: 'purchases', component: PurchaseListComponent },
  { path: 'purchases/new', component: PurchaseFormComponent },
  { path: 'purchases/:userId/:gameId', component: PurchaseFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class PurchaseRoutingModule { }

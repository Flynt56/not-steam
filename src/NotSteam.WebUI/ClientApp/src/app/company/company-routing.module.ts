import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { CompanyListComponent } from './company-list/company-list.component';
import { CompanyFormComponent } from './company-form/company-form.component';
import { AuthGuard } from '../auth/auth.guard';


const routes: Routes = [
  { path: 'companies', component: CompanyListComponent },
  { path: 'companies/new', component: CompanyFormComponent, canActivate: [AuthGuard] },
  { path: 'companies/edit/:id', component: CompanyFormComponent, canActivate: [AuthGuard] }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class CompanyRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TagListComponent } from './tag-list/tag-list.component';
import { TagFormComponent } from './tag-form/tag-form.component';
import { AuthGuard } from '../auth/auth.guard';


const routes: Routes = [
  { path: 'tags', component: TagListComponent },
  { path: 'tags/new', component: TagFormComponent, canActivate: [AuthGuard] },
  { path: 'tags/edit/:id', component: TagFormComponent, canActivate: [AuthGuard] }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TagRoutingModule { }

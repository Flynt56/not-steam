import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TagListComponent } from './tag-list/tag-list.component';
import { TagFormComponent } from './tag-form/tag-form.component';


const routes: Routes = [
  { path: 'tags', component: TagListComponent },
  { path: 'tags/new', component: TagFormComponent },
  { path: 'tags/:id', component: TagFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TagRoutingModule { }

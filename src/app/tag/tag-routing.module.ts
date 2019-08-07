import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { TagListComponent } from './tag-list/tag-list.component';


const routes: Routes = [
  { path: 'tags', component: TagListComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class TagRoutingModule { }

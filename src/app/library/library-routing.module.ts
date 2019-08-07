import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LibraryListComponent } from './library-list/library-list.component';


const routes: Routes = [
  { path: 'libraries', component: LibraryListComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LibraryRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { LibraryListComponent } from './library-list/library-list.component';
import { LibraryFormComponent } from './library-form/library-form.component';


const routes: Routes = [
  { path: 'libraries', component: LibraryListComponent },
  { path: 'libraries/new', component: LibraryFormComponent },
  { path: 'libraries/:id/:id2', component: LibraryFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class LibraryRoutingModule { }

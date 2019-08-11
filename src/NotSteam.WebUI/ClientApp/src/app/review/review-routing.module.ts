import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { ReviewListComponent } from './review-list/review-list.component';
import { ReviewFormComponent } from './review-form/review-form.component';


const routes: Routes = [
  { path: 'reviews', component: ReviewListComponent },
  { path: 'reviews/new', component: ReviewFormComponent },
  { path: 'reviews/:id/:id2', component: ReviewFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class ReviewRoutingModule { }

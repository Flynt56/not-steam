import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { ReviewRoutingModule } from './review-routing.module';
import { ReviewListComponent } from './review-list/review-list.component';
import { ReviewFormComponent } from './review-form/review-form.component';


@NgModule({
  declarations: [ReviewListComponent, ReviewFormComponent],
  imports: [
    CommonModule,
    ReviewRoutingModule
  ]
})
export class ReviewModule { }

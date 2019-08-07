import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagRoutingModule } from './tag-routing.module';
import { TagListComponent } from './tag-list/tag-list.component';


@NgModule({
  declarations: [TagListComponent],
  imports: [
    CommonModule,
    TagRoutingModule
  ]
})
export class TagModule { }

import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagRoutingModule } from './tag-routing.module';
import { TagListComponent } from './tag-list/tag-list.component';
import { TagFormComponent } from './tag-form/tag-form.component';


@NgModule({
  declarations: [TagListComponent, TagFormComponent],
  imports: [
    CommonModule,
    TagRoutingModule
  ]
})
export class TagModule { }

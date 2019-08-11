import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { TagRoutingModule } from './tag-routing.module';
import { TagListComponent } from './tag-list/tag-list.component';
import { TagFormComponent } from './tag-form/tag-form.component';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [TagListComponent, TagFormComponent],
  imports: [
    CommonModule,
    TagRoutingModule,
    FormsModule,
    BrowserAnimationsModule
  ]
})
export class TagModule { }

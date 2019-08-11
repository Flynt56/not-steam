import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { LibraryRoutingModule } from './library-routing.module';
import { LibraryListComponent } from './library-list/library-list.component';
import { LibraryFormComponent } from './library-form/library-form.component';
import { FormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';


@NgModule({
  declarations: [LibraryListComponent, LibraryFormComponent],
  imports: [
    CommonModule,
    LibraryRoutingModule,
    FormsModule,
    BrowserAnimationsModule
  ]
})
export class LibraryModule { }

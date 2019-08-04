import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { NavbarRoutingModule } from './navbar-routing.module';
import { NavbarBaseComponent } from './navbar-base/navbar-base.component';


@NgModule({
  declarations: [NavbarBaseComponent],
  imports: [
    CommonModule,
    NavbarRoutingModule
  ]
})
export class NavbarModule { }

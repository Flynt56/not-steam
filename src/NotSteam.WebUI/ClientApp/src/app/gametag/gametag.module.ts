import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GametagRoutingModule } from './gametag-routing.module';
import { GametagListComponent } from './gametag-list/gametag-list.component';


@NgModule({
  declarations: [GametagListComponent],
  imports: [
    CommonModule,
    GametagRoutingModule
  ]
})
export class GametagModule { }

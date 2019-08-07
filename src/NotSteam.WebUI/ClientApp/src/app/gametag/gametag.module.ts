import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GametagRoutingModule } from './gametag-routing.module';
import { GametagListComponent } from './gametag-list/gametag-list.component';
import { GametagFormComponent } from './gametag-form/gametag-form.component';


@NgModule({
  declarations: [GametagListComponent, GametagFormComponent],
  imports: [
    CommonModule,
    GametagRoutingModule
  ]
})
export class GametagModule { }

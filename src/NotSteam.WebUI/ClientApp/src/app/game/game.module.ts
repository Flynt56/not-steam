import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { GameRoutingModule } from './game-routing.module';
import { GameListComponent } from './game-list/game-list.component';
import { GameFormComponent } from './game-form/game-form.component';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { FormsModule } from '@angular/forms';


@NgModule({
  declarations: [GameListComponent, GameFormComponent],
  imports: [
    CommonModule,
    GameRoutingModule,
    FormsModule,
    BrowserAnimationsModule
  ]
})
export class GameModule { }

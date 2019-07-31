import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GametagListComponent } from './gametag-list/gametag-list.component';


const routes: Routes = [
  { path: 'gametags', component: GametagListComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GametagRoutingModule { }

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GametagListComponent } from './gametag-list/gametag-list.component';
import { GametagFormComponent } from './gametag-form/gametag-form.component';


const routes: Routes = [
  { path: 'gametags', component: GametagListComponent },
  { path: 'gametags/new', component: GametagFormComponent },
  { path: 'gametags/:gameId/:tagId', component: GametagFormComponent }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GametagRoutingModule { }

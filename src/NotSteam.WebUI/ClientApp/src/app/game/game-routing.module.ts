import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { GameListComponent } from './game-list/game-list.component';
import { GameFormComponent } from './game-form/game-form.component';
import { AuthGuard } from '../auth/auth.guard';


const routes: Routes = [
  { path: 'games', component: GameListComponent },
  { path: 'games/new', component: GameFormComponent, canActivate: [AuthGuard] },
  { path: 'games/edit/:id', component: GameFormComponent, canActivate: [AuthGuard] }
];

@NgModule({
  imports: [RouterModule.forChild(routes)],
  exports: [RouterModule]
})
export class GameRoutingModule { }

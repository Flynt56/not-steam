import { Component, OnInit } from '@angular/core';
import { GameService } from '../game.service';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.scss']
})
export class GameListComponent implements OnInit {

  constructor(
    private gameService: GameService
  ) { }

  private games = [];

  ngOnInit() {
    this.gameService.getAll().subscribe((response: any) => {
      this.games = response;
    });
  }

}

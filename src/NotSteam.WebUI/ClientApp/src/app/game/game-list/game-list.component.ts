import { Component, OnInit } from '@angular/core';
import { GameService } from '../game.service';
import { Router } from '@angular/router';
import { CommonService } from 'src/app/shared/common.service';
import { GameList } from '../model/GameList';
import { Pagination } from 'src/app/shared/Response/Pagination';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.scss']
})
export class GameListComponent implements OnInit {

  constructor(
    private gameService: GameService,
    private router: Router,
    private common: CommonService
  ) { }

  private games = Array<GameList>();
  private pagination: Pagination;

  ngOnInit() {
    this.getAllGames();
  }

  getAllGames() {
    this.gameService
      .getPage(1)
      .subscribe(({ data, pagination }) => {
        this.pagination = pagination;
        this.games = data;
        this.common.hide();
      });;
  }

  onDelete(gameId) {
    if (confirm('Jeste li sigurni?')) {
      this.gameService.deleteOneById(gameId).subscribe(result => {
        this.getAllGames();
        this.common.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['games/new']);
  }

  onEdit(gameId) {
    this.common.show();
    this.router.navigate(['games', 'edit', gameId]);
  }
}

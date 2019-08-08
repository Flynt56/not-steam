import { Component, OnInit } from '@angular/core';
import { GameService } from '../game.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-game-list',
  templateUrl: './game-list.component.html',
  styleUrls: ['./game-list.component.scss']
})
export class GameListComponent implements OnInit {

  constructor(
    private gameService: GameService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private games = [];

  ngOnInit() {
    this.getAllGames();
  }

  getAllGames() {
    this.gameService.getAll().subscribe((response: any) => {
      this.games = response;
    });
  }

  onDelete(gameId) {
    if (confirm('Jeste li sigurni?')) {
      this.gameService.deleteOne(gameId).subscribe(result => {
        this.getAllGames();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['games/new']);
  }

  onEdit(gameId) {
    this.spinner.show();
    this.router.navigate(['games', gameId]);
  }
}

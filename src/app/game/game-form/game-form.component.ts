import { Component, OnInit } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { GameService } from '../game.service';

@Component({
  selector: 'app-game-form',
  templateUrl: './game-form.component.html',
  styleUrls: ['./game-form.component.scss']
})
export class GameFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private gameService: GameService
  ) { }

  public game: any = {};
  public companies: any = [];

  ngOnInit() {
    this.route.params.subscribe(params => {
      const gameId = params['id'];
      if (gameId != null) {
        this.getGame(gameId);
      }
    });
  }

  getGame(gameId) {
    this.gameService.getOne(gameId).subscribe(response => {
      this.game = response;
      this.game.id = gameId;
    }
    );
  }

  // getCompanies() {
  //     this.companyService.getAll().subscribe(response => 
  //       {
  //         this.companies = response;
  //       }
  //     );
  // }

}

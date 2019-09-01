import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GameService } from '../game.service';
import { CompanyService } from 'src/app/company/company.service';
import { CommonService } from 'src/app/shared/common.service';
import { CompanyDropdown } from 'src/app/company/model/CompanyDropdown';
import { GameDetails } from '../model/GameDetails';
import { GameEditForm } from '../model/GameEditForm';

@Component({
  selector: 'app-game-form',
  templateUrl: './game-form.component.html',
  styleUrls: ['./game-form.component.scss']
})
export class GameFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private gameService: GameService,
    private router: Router,
    private companyService: CompanyService,
    private common: CommonService
  ) { }

  public game: GameDetails = new GameDetails();
  public companies: Array<CompanyDropdown> = new Array<CompanyDropdown>();
  public errorMessage = '';

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const gameId = params.get('id');

      if (gameId != null) {
        this.getGameEditForm(gameId);
      } else {
        this.getCompaniesMap();
      }
    });
  }

  getGameEditForm(gameId) {
    this.gameService.getEditFormById(gameId)
      .subscribe((response: GameEditForm) => {
        this.game = response.game;
        this.companies = response.companies;

        this.common.hide();
      });
  }

  getGame(gameId) {
    this.gameService.getOneById(gameId).subscribe(response => {
      this.game = response;
      this.common.hide();
    });
  }

  onSubmit() {
    this.common.show();

    this.gameService.submit(this.game).subscribe(
      () => {
        this.common.success('Uspješno izvršeno!');
        this.router.navigate(['games']);
        this.common.hide();
      },
      (response: any) => {
        const firstError = response.error.errors;
        const firstKey = Object.keys(firstError)[0];
        this.errorMessage = firstError[firstKey][0];
        this.common.hide();
      });
  }

  getCompaniesMap() {
    this.companyService.getDropdown<CompanyDropdown>()
      .subscribe(response => {
        this.companies = response;
      });
  }

}

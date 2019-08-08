import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GameService } from '../game.service';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';
import { CompanyService } from 'src/app/company/company.service';

@Component({
  selector: 'app-game-form',
  templateUrl: './game-form.component.html',
  styleUrls: ['./game-form.component.scss']
})
export class GameFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private gameService: GameService,
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService,
    private companyService: CompanyService
  ) { }

  public game: any = {};
  public companies: any = [];
  public selectedCompany: any = {};
  public errorMessage = "";

  ngOnInit() {
    this.route.params.subscribe(params => {
      const gameId = params['id'];
      if (gameId != null) {
        this.getGame(gameId);
        this.getCompanies();
      }
    });
  }

  getGame(gameId) {
    this.gameService.getOne(gameId).subscribe(response => {
      this.game = response;
      this.game.id = gameId;
      this.spinner.hide();
    }
    );
  }

  onSubmit() {
    this.spinner.show();
    this.game.companyId = this.selectedCompany.id;

    this.gameService.submit(this.game).subscribe(
      (response: any) => {
        this.toastr.success('dosta gey');
        this.router.navigate(['games']);
        this.spinner.hide();
      },
      (response: any) => {
        const firstError = response.error.errors;
        const firstKey = Object.keys(firstError)[0];
        this.errorMessage = firstError[firstKey][0];
        this.spinner.hide();
      });
  }

  getCompanies() {
      this.companyService.getAll().subscribe(response => 
        {
          this.companies = response;
        }
      );
  }

}

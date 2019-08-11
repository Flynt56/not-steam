import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { GameService } from 'src/app/game/game.service';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';
import { PurchaseService } from '../purchase.service';
import { UserService } from 'src/app/user/user.service';

@Component({
  selector: 'app-purchase-form',
  templateUrl: './purchase-form.component.html',
  styleUrls: ['./purchase-form.component.scss']
})
export class PurchaseFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private purchaseService: PurchaseService,
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService,
    private gameService: GameService,
    private userService: UserService
  ) { }

  public bIsNew = true;
  public purchase: any = {};

  public games: any = [];
  public users: any = [];

  public selectedUserId: any = {};
  public selectedGameId: any = {};

  public errorMessage = '';

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const userId = params.get('id');
      const gameId = params.get('id2');

      this.bIsNew = userId == null || gameId == null;

      if (!this.bIsNew) {
        this.getPurchase(userId, gameId);
      }

      this.getGames();
      this.getUsers();
      this.spinner.hide();
    });
  }

  getPurchase(userId, gameId) {
    this.purchaseService.getOne(userId, gameId).subscribe(response => {
      this.purchase = response;
    });
  }

  onSubmit() {
    this.spinner.show();

    if (this.bIsNew) {
      this.purchase.userId = this.selectedUserId;
      this.purchase.gameId = this.selectedGameId;

      this.purchaseService.submitNew(this.purchase).subscribe(
        () => {
          this.toastr.success('Uspješno izvršeno!');
          this.router.navigate(['purchases']);
          this.spinner.hide();
        },
        (response: any) => {
          const firstError = response.error.errors;
          const firstKey = Object.keys(firstError)[0];
          this.errorMessage = firstError[firstKey][0];
          this.spinner.hide();
        });
    } else {
      this.purchaseService.submit(this.purchase).subscribe(
        () => {
          this.toastr.success('Uspješno izvršeno!');
          this.router.navigate(['purchases']);
          this.spinner.hide();
        },
        (response: any) => {
          const firstError = response.error.errors;
          const firstKey = Object.keys(firstError)[0];
          this.errorMessage = firstError[firstKey][0];
          this.spinner.hide();
        });
    }
  }

  getGames() {
    this.gameService.getAll().subscribe(response => {
      this.games = response;
    });
  }

  getUsers() {
    this.userService.getAll().subscribe(response => {
      this.users = response;
    })
  }
}

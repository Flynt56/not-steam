import { Component, OnInit } from '@angular/core';
import { ReviewService } from '../review.service';
import { ActivatedRoute, Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';
import { GameService } from 'src/app/game/game.service';
import { UserService } from 'src/app/user/user.service';

@Component({
  selector: 'app-review-form',
  templateUrl: './review-form.component.html',
  styleUrls: ['./review-form.component.scss']
})
export class ReviewFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private reviewService: ReviewService,
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService,
    private gameService: GameService,
    private userService: UserService
  ) { }

  public bIsNew = true;
  public review: any = {};

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
        this.getReview(userId, gameId);
      }

      this.getGames();
      this.getUsers();
      this.spinner.hide();
    });
  }

  getReview(userId, gameId) {
    this.reviewService.getOne(userId, gameId).subscribe(response => {
      this.review = response;
    });
  }

  onSubmit() {
    this.spinner.show();

    if (this.bIsNew) {
      this.review.userId = this.selectedUserId;
      this.review.gameId = this.selectedGameId;

      this.reviewService.submitNew(this.review).subscribe(
        () => {
          this.toastr.success('Uspješno izvršeno!');
          this.router.navigate(['reviews']);
          this.spinner.hide();
        },
        (response: any) => {
          const firstError = response.error.errors;
          const firstKey = Object.keys(firstError)[0];
          this.errorMessage = firstError[firstKey][0];
          this.spinner.hide();
        });
    } else {
      this.reviewService.submit(this.review).subscribe(
        () => {
          this.toastr.success('Uspješno izvršeno!');
          this.router.navigate(['reviews']);
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
    });
  }
}

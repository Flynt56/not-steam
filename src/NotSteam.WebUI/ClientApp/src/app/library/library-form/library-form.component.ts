import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';
import { GameService } from 'src/app/game/game.service';
import { UserService } from 'src/app/user/user.service';
import { LibraryService } from '../library.service';

@Component({
  selector: 'app-library-form',
  templateUrl: './library-form.component.html',
  styleUrls: ['./library-form.component.scss']
})
export class LibraryFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private libraryService: LibraryService,
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService,
    private gameService: GameService,
    private userService: UserService
  ) { }

  public bIsNew = true;
  public library: any = {};

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
        this.getLibrary(userId, gameId);
      }

      this.getGames();
      this.getUsers();
      this.spinner.hide();
    });
  }

  getLibrary(userId, gameId) {
    this.libraryService.getOne(userId, gameId).subscribe(response => {
      this.library = response;
    });
  }

  onSubmit() {
    this.spinner.show();

    if (this.bIsNew) {
      this.library.userId = this.selectedUserId;
      this.library.gameId = this.selectedGameId;

      this.libraryService.submitNew(this.library).subscribe(
        () => {
          this.toastr.success('Uspješno izvršeno!');
          this.router.navigate(['libraries']);
          this.spinner.hide();
        },
        (response: any) => {
          const firstError = response.error.errors;
          const firstKey = Object.keys(firstError)[0];
          this.errorMessage = firstError[firstKey][0];
          this.spinner.hide();
        });
    } else {
      this.libraryService.submit(this.library).subscribe(
        () => {
          this.toastr.success('Uspješno izvršeno!');
          this.router.navigate(['libraries']);
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

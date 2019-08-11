import { Component, OnInit } from '@angular/core';
import { TagService } from 'src/app/tag/tag.service';
import { GameService } from 'src/app/game/game.service';
import { ActivatedRoute, Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';
import { ToastrService } from 'ngx-toastr';
import { GametagService } from '../gametag.service';

@Component({
  selector: 'app-gametag-form',
  templateUrl: './gametag-form.component.html',
  styleUrls: ['./gametag-form.component.scss']
})
export class GametagFormComponent implements OnInit {

  constructor(
    private spinner: SpinnerService,
    private router: Router,
    private toastr: ToastrService,
    private gameService: GameService,
    private tagService: TagService,
    private gameTagService: GametagService
  ) { }

  public gameTag: any = {};

  public errorMessage = '';

  public tags: any = [];
  public games: any = [];

  public selectedTagId: any = {};
  public selectedGameId: any = {};

  ngOnInit() {
    this.getGames();
    this.getTags();
    this.spinner.hide();
  }

  onSubmit() {
    this.spinner.show();
    this.gameTag.gameId = this.selectedGameId;
    this.gameTag.tagId = this.selectedTagId;

    this.gameTagService.submit(this.gameTag).subscribe(
      (response: any) => {
        this.toastr.success('Uspješno izvršeno!');
        this.router.navigate(['gametags']);
        this.spinner.hide();
      },
      (response: any) => {
        const firstError = response.error.errors;
        const firstKey = Object.keys(firstError)[0];
        this.errorMessage = firstError[firstKey][0];
        this.spinner.hide();
      });
  }

  getGames() {
    this.gameService.getAll().subscribe(response => {
      this.games = response;
    });
  }

  getTags() {
    this.tagService.getAll().subscribe(response => {
      this.tags = response;
    });
  }

}

import { Component, OnInit } from '@angular/core';
import { GametagService } from '../gametag.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-gametag-list',
  templateUrl: './gametag-list.component.html',
  styleUrls: ['./gametag-list.component.scss']
})
export class GametagListComponent implements OnInit {

  constructor(
    private gametagService: GametagService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private gametags = [];

  ngOnInit() {
    this.getAllGameTags();
  }

  getAllGameTags() {
    this.gametagService.getAll().subscribe((response: any) => {
      this.gametags = response;
    });
  }

  onDelete(gameId, tagId) {
    if (confirm('Jeste li sigurni?')) {
      this.gametagService.deleteOne(gameId, tagId).subscribe(result => {
        this.getAllGameTags();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['gametags/new']);
  }

  onEdit(gameId, tagId) {
    this.spinner.show();
    this.router.navigate(['gametags', gameId, tagId]);
  }

}

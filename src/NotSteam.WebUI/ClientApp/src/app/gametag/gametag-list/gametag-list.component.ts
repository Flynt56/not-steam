import { Component, OnInit } from '@angular/core';
import { GametagService } from '../gametag.service';

@Component({
  selector: 'app-gametag-list',
  templateUrl: './gametag-list.component.html',
  styleUrls: ['./gametag-list.component.scss']
})
export class GametagListComponent implements OnInit {

  constructor(
    private gametagService: GametagService
  ) { }

  private gametags = [];

  ngOnInit() {
    this.gametagService.getAll().subscribe((response: any) => {
      this.gametags = response;
    });
  }

}

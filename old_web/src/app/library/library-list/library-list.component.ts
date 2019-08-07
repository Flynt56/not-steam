import { Component, OnInit } from '@angular/core';
import { LibraryService } from '../library.service';

@Component({
  selector: 'app-library-list',
  templateUrl: './library-list.component.html',
  styleUrls: ['./library-list.component.scss']
})
export class LibraryListComponent implements OnInit {

  constructor(
    private libraryService: LibraryService
  ) { }

  private libraries = [];

  ngOnInit() {
    this.libraryService.getAll().subscribe((response: any) => {
      this.libraries = response;
    });
  }

}

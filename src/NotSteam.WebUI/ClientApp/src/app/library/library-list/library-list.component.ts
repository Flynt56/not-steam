import { Component, OnInit } from '@angular/core';
import { LibraryService } from '../library.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-library-list',
  templateUrl: './library-list.component.html',
  styleUrls: ['./library-list.component.scss']
})
export class LibraryListComponent implements OnInit {

  constructor(
    private libraryService: LibraryService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private libraries = [];

  ngOnInit() {
    this.getAllLibraries();
  }

  getAllLibraries() {
    this.libraryService.getAll().subscribe((response: any) => {
      this.libraries = response;
    });
  }

  onDelete(userId, gameId) {
    if (confirm('Jeste li sigurni?')) {
      this.libraryService.deleteOne(userId, gameId).subscribe(result => {
        this.getAllLibraries();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['libraries/new']);
  }

  onEdit(userId, gameId) {
    this.spinner.show();
    this.router.navigate(['libraries', userId, gameId]);
  }

}

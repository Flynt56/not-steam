import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { ToastrService } from 'ngx-toastr';
import { Router } from '@angular/router';
import { SpinnerService } from 'src/app/shared/spinner.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  constructor(
    private userService: UserService,
    private toastr: ToastrService,
    private router: Router,
    private spinner: SpinnerService
  ) { }

  private users = [];

  ngOnInit() {
    this.getAllUsers();
  }

  getAllUsers() {
    this.userService.getAll().subscribe((response: any) => {
      this.users = response;
    });
  }

  onDelete(userId) {
    if (confirm('Jeste li sigurni?')) {
      this.userService.deleteOne(userId).subscribe(result => {
        this.getAllUsers();
        this.toastr.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['users/new']);
  }

  onEdit(userId) {
    this.spinner.show();
    this.router.navigate(['users', userId]);
  }

}

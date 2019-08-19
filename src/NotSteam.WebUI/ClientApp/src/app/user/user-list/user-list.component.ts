import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';
import { Router } from '@angular/router';
import { UserList } from '../model/UserList';
import { Pagination } from 'src/app/shared/Response/Pagination';
import { CommonService } from 'src/app/shared/common.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  constructor(
    private userService: UserService,
    private common: CommonService,
    private router: Router,
  ) { }

  private users = Array<UserList>();
  private pagination: Pagination;

  ngOnInit() {
    this.getUsers();
  }

  getUsers() {
    this.userService
      .getPage(1)
      .subscribe(({ data, pagination }) => {
        this.pagination = pagination;
        this.users = data;
        this.common.hide();
      });
  }

  onDelete(userId) {
    if (confirm('Jeste li sigurni?')) {
      this.userService.deleteOneById(userId).subscribe(result => {
        this.getUsers();
        this.common.success('Uspješno obrisano!');
      });
    }
  }

  onAdd() {
    this.router.navigate(['users/new']);
  }

  onEdit(userId) {
    this.common.show();
    this.router.navigate(['users', userId]);
  }

}

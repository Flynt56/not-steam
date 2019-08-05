import { Component, OnInit } from '@angular/core';
import { UserService } from '../user.service';

@Component({
  selector: 'app-user-list',
  templateUrl: './user-list.component.html',
  styleUrls: ['./user-list.component.scss']
})
export class UserListComponent implements OnInit {

  constructor(
    private userService: UserService
  ) { }

  private users = [];
  private name: string;

  ngOnInit() {
    this.userService.getAll().subscribe((response: any) => {
      this.users = response;
    });
  }

  onClickEdit() {

  }

  onClickDelete() {
    console.log('TEST DELETE');
  }

}

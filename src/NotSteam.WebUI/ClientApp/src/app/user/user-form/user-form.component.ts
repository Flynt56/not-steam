import { Component, OnInit } from '@angular/core';
import { ActivatedRoute, Router } from '@angular/router';
import { UserService } from '../user.service';
import { CommonService } from 'src/app/shared/common.service';
import { UserDetails } from '../model/user-details';
import { User } from '../model/user';

@Component({
  selector: 'app-user-form',
  templateUrl: './user-form.component.html',
  styleUrls: ['./user-form.component.scss']
})
export class UserFormComponent implements OnInit {

  constructor(
    private route: ActivatedRoute,
    private userService: UserService,
    private router: Router,
    private common: CommonService
  ) { }

  public user: UserDetails;
  public errorMessage = '';

  ngOnInit() {
    this.route.paramMap.subscribe(params => {
      const userId = params.get('id');

      if (userId != null) {
        this.getUser(userId);
      }
    });
  }

  getUser(userId) {
    this.userService.getOne(userId).subscribe(response => {
      this.user = response;
      this.common.hide();
    });
  }

  onSubmit() {
    this.common.show();

    const postUser: User = {};

    postUser.id = this.user.id;
    postUser.username = this.user.name;
    postUser.nickname = this.user.nick;
    postUser.password = this.user.password;
    postUser.email = this.user.email;
    postUser.dateOfBirth = this.user.dob;
    postUser.profileImageUri = this.user.profileImageUri;

    this.userService.submit(postUser).subscribe(
      () => {
        this.common.success('Uspješno izvršeno!');
        this.router.navigate(['users']);
        this.common.hide();
      },
      (response: any) => {
        const firstError = response.error.errors;
        const firstKey = Object.keys(firstError)[0];
        this.errorMessage = firstError[firstKey][0];
        this.common.hide();
      });
  }

}

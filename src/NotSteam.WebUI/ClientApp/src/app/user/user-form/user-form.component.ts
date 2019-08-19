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

    const postUser: User = {
      id: this.user.id,
      username: this.user.name,
      nickname: this.user.nick,
      password: this.user.password,
      email: this.user.email,
      dateOfBirth: this.user.dob,
      profileImageUri: this.user.profileImageUri
    };

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

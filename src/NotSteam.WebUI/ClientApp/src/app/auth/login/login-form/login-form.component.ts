import { Component, OnInit } from '@angular/core';
import { Login } from '../login';
import { AuthService } from '../../auth.service';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {

  constructor(
    private auth: AuthService
  ) { }

  public user: Login = new Login();
  public errorMessage = '';

  ngOnInit() {
  }

  onSubmit() {
    this.auth.login(this.user)
      .subscribe((response: any) => {
        console.log(response);
      });
  }
}

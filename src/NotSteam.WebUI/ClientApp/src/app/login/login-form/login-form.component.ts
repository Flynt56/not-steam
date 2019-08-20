import { Component, OnInit } from '@angular/core';
import { Login } from '../login';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {

  constructor() { }

  public user: Login = new Login();

  ngOnInit() {

  }

  onSubmit() {
    console.log(this.user);
  }
}

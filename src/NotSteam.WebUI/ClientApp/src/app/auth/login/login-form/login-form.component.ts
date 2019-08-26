import { Component, OnInit } from '@angular/core';
import { Login } from '../login';
<<<<<<< HEAD
=======
import { AuthService } from '../../auth.service';
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {

<<<<<<< HEAD
  constructor() { }
=======
  constructor(
    private auth: AuthService
  ) { }
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85

  public user: Login = new Login();
  public errorMessage = '';

  ngOnInit() {
  }

  onSubmit() {
<<<<<<< HEAD
    console.log(this.user);
=======
    this.auth.login(this.user);
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85
  }
}

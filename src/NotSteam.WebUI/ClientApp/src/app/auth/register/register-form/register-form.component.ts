import { Component, OnInit } from '@angular/core';
import { Register } from '../register';
import { AuthService } from '../../auth.service';
import { JwtService } from '../../jwt.service';
import { Router } from '@angular/router';
import { CommonService } from 'src/app/shared/common.service';
import { format } from 'path';
import { DetailResponse } from 'src/app/shared/Response/DetailResponse';
import { AuthResponse } from '../../models/AuthResponse';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss']
})
export class RegisterFormComponent implements OnInit {

  constructor(
    private auth: AuthService,
    private jwt: JwtService,
    private router: Router,
    private common: CommonService
  ) { }

  public user: Register = new Register();
  public errorMessage = '';

  ngOnInit() {
    this.common.hide();
  }

  onSubmit() {
    this.onRegister();
  }

  onRegister() {
    this.auth.register(this.user).subscribe((response: DetailResponse<AuthResponse>) => {
      this.jwt.updateUserAuth(response.response.token, response.response.user);

      this.router.navigate(['/']);

      setTimeout(() => {
        location.reload();
      }, 300);
    },

      (response) => {
        if (response.error.Message === 'EMAIL_EXISTS') {
          this.common.error('Your provided email address already exists!');

          this.user.password = '';
          this.user.email = '';
        }

      });

    return false;
  }
}

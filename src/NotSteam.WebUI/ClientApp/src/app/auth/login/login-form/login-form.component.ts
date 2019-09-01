import { Component, OnInit } from '@angular/core';
import { Login } from '../login';
import { AuthService } from '../../auth.service';
import { JwtService } from '../../jwt.service';
import { CommonService } from 'src/app/shared/common.service';
import { Router, ActivatedRoute } from '@angular/router';
import { AuthResponse } from '../../models/AuthResponse';
import { DetailResponse } from 'src/app/shared/Response/DetailResponse';

@Component({
  selector: 'app-login-form',
  templateUrl: './login-form.component.html',
  styleUrls: ['./login-form.component.scss']
})
export class LoginFormComponent implements OnInit {

  constructor(
    private auth: AuthService,
    private jwt: JwtService,
    private common: CommonService,
    private router: Router,
    private route: ActivatedRoute
  ) { }

  public user: Login = new Login();
  public errorMessage = '';

  public returnUrl = '';

  ngOnInit() {
    this.route.queryParamMap.subscribe(params => {
      this.returnUrl = params.get('returnUrl');
    });

    this.common.hide();
  }

  onSubmit() {
    this.onLogin();
  }

  onLogin() {
    this.auth.login(this.user).subscribe((response: DetailResponse<AuthResponse>) => {
      this.jwt.updateUserAuth(response.response.token, response.response.user);

      if (this.hasReturnUrl()) {
        this.router.navigate([this.returnUrl]);
      } else {
        this.router.navigate(['/']);
      }

      setTimeout(() => {
        location.reload();
      }, 300);
    },

      (response) => {
        if (response.error.Message === 'WRONG_EMAIL_PASSWORD') {
          this.common.error('Wrong email or password!');

          this.user.password = '';
        }

      });

    return false;
  }

  private hasReturnUrl() {
    return this.returnUrl !== null && this.returnUrl.length > 0;
  }

}

import { Component, OnInit } from '@angular/core';
import { Register } from '../register';
import { AuthService } from '../../auth.service';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss']
})
export class RegisterFormComponent implements OnInit {

  constructor(
    private auth: AuthService
  ) { }

  public user: Register = new Register();
  public errorMessage = '';

  ngOnInit() {
  }

  onSubmit() {
    this.auth.register(this.user)
      .subscribe((response: any) => {
        console.log(response);
      });
  }
}

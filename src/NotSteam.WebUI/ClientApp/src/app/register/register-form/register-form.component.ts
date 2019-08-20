import { Component, OnInit } from '@angular/core';
import { Register } from '../register';

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss']
})
export class RegisterFormComponent implements OnInit {

  constructor(
  ) { }

  public user: Register = new Register();

  ngOnInit() {

  }

  onSubmit() {
    console.log(this.user);
  }
}

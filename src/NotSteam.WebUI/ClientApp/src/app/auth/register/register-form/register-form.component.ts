import { Component, OnInit } from '@angular/core';
import { Register } from '../register';
<<<<<<< HEAD
=======
import { AuthService } from '../../auth.service';
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85

@Component({
  selector: 'app-register-form',
  templateUrl: './register-form.component.html',
  styleUrls: ['./register-form.component.scss']
})
export class RegisterFormComponent implements OnInit {

  constructor(
<<<<<<< HEAD
=======
    private auth: AuthService
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85
  ) { }

  public user: Register = new Register();
  public errorMessage = '';

  ngOnInit() {
  }

  onSubmit() {
<<<<<<< HEAD
    console.log(this.user);
=======
    this.auth.register(this.user);
>>>>>>> 5bf6fdb8f380604825559e39cb82991caee13c85
  }
}

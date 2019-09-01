import { Component, OnInit } from '@angular/core';
import { JwtService } from 'src/app/auth/jwt.service';
import { Router } from '@angular/router';

@Component({
  selector: 'app-navbar',
  templateUrl: './navbar.component.html',
  styleUrls: ['./navbar.component.scss']
})
export class NavbarComponent implements OnInit {

  constructor(
    private jwt: JwtService,
    private router: Router
  ) { }

  ngOnInit() {
  }

  onLogin() {
    this.router.navigate(['/login']);
  }

  onRegister() {
    this.router.navigate(['/register']);
  }

  onLogout() {
    this.jwt.logout();
  }
}

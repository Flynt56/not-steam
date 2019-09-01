import { Injectable } from '@angular/core';
import { ActivatedRouteSnapshot, RouterStateSnapshot, UrlTree, CanActivate, Router } from '@angular/router';
import { JwtService } from './jwt.service';
import { CommonService } from '../shared/common.service';

@Injectable({
  providedIn: 'root'
})
export class AuthGuard implements CanActivate {

  constructor(
    private router: Router,
    private jwt: JwtService,
    private common: CommonService
  ) { }

  canActivate(route: ActivatedRouteSnapshot, state: RouterStateSnapshot) {
    if (this.jwt.isLoggedIn()) {
      return true;
    }

    this.common.accessDeniedMessage();
    this.router.navigate(['/login'], { queryParams: { returnUrl: state.url } });

    return false;
  }

}

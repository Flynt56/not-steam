import { Injectable } from '@angular/core';
import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Observable, throwError } from 'rxjs';
import { JwtService } from '../auth/jwt.service';
import { catchError } from 'rxjs/operators';
import { CommonService } from './common.service';
import { Router } from '@angular/router';

@Injectable()
export class AuthErrorInterceptor implements HttpInterceptor {

    constructor(
        private jwt: JwtService,
        private common: CommonService,
        private router: Router
    ) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        return next.handle(request)
            .pipe(catchError(err => {
                if (err.status === 401) {
                    this.jwt.logout();
                    this.common.error('You are not authorized!');

                    this.router.navigate(['/login'], { queryParams: { returnUrl: request.url } });
                }

                const error = err.error.message || err.statusText;
                return throwError(error);
            }));
    }
}

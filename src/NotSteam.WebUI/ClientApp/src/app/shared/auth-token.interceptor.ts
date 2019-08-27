import { Injectable } from '@angular/core';
import { HttpEvent, HttpHandler, HttpInterceptor, HttpRequest } from '@angular/common/http';
import { Observable } from 'rxjs';
import { JwtService } from '../auth/jwt.service';

@Injectable()
export class AuthTokenInterceptor implements HttpInterceptor {

    constructor(
        private jwt: JwtService
    ) { }

    intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
        if (this.jwt.isLoggedIn()) {
            const authRequest = request.clone({
                headers: request.headers.set('Authorization', this.jwt.getFullToken())
                    .set('Content-Type', 'application/json')
                    .set('Accept', 'application/json')
            });

            return next.handle(authRequest);
        }

        return next.handle(request);
    }

}

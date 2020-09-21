import {Injectable} from '@angular/core';
import {
  HttpRequest,
  HttpHandler,
  HttpEvent,
  HttpInterceptor,
  HttpErrorResponse
} from '@angular/common/http';
import {Observable, of} from 'rxjs';
import {Router} from '@angular/router';
import {catchError } from 'rxjs/internal/operators';

@Injectable({
  providedIn: 'root'
})
export class ErrorInterceptor implements HttpInterceptor {

  constructor(private router: Router) {}
  /**
   * intercept all XHR request
   * @param request
   * @param next
   * @returns {Observable<A>}
   */
  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    return next.handle(request).pipe(catchError((error, caught) => {
        // intercept the respons error and displace it to the console
        console.log(error);
        this.handleError(error);
        return of(error);
      }) as any);
  }

  /**
   * manage errors
   * @param err
   * @returns {any}
   */
  private handleError(err: HttpErrorResponse): Observable<any> {
    // handle your auth error or rethrow
    if (err.status === 0) {
      console.log(err.message);
      return of(err.message);
    } else if (err.status === 401) {
      // navigate /delete cookies or whatever
      console.log('handled error ' + err.status);
      // this.router.navigate([`/login`]);
      // if you've caught / handled the error, you don't want to rethrow it
      // unless you also want downstream consumers to have to handle it as well.
      return of(err.message);
    } else if (err.status === 404) {
      console.log(err.message);
      return of(err.message);
    } else {
      console.log(err.message);
    }
    throw err;
  }
}
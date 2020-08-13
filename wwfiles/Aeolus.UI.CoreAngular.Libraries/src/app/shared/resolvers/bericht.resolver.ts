import { Injectable } from '@angular/core';
import { Resolve, Router, ActivatedRouteSnapshot } from '@angular/router';
import { AppService } from '../services/app.service';
import { Observable, of } from 'rxjs';
import { catchError } from 'rxjs/operators';
import { Bericht, Bericht2 } from '../models/bericht';

@Injectable({
  providedIn: 'root'
})
export class BerichtResolver implements Resolve<Bericht2> {

  constructor(private appService: AppService, private router: Router) { }

  resolve(router: ActivatedRouteSnapshot): Observable<Bericht2> {
    return this.appService.getBerichtById(router.params['id']).pipe(catchError(error => {
      console.log('Probleem met data ophalen');
      this.router.navigate(['/home']);
      return of(null);
    }));
  }

}

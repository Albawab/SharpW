import { Injectable } from '@angular/core';
import { CanActivate } from '@angular/router';
import { Router } from '@angular/router';
import { OpenIdConnectService } from '../../shared/services/open-id-connect.service';

@Injectable()
export class AuthGuard implements CanActivate {

    constructor (private openIdConnectService: OpenIdConnectService, private router: Router) {}

    canActivate() {
      // if (this.openIdConnectService.userAvailable) {
      //     return true;
      // } else {
      //     this.openIdConnectService.triggerSignIn();
      //     return false;
      // }
      return true;

      // if (localStorage.getItem('isLoggedin')) {
      //     return true;
      // }

      // this.router.navigate(['/login']);
      // return false;
    }
}

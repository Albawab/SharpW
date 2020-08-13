import { Injectable } from '@angular/core';
import { UserManager, User } from 'oidc-client';
import { ReplaySubject } from 'rxjs';
import { environment } from '../../../environments/environment';
import { Location } from '@angular/common';

@Injectable({
  providedIn: 'root'
})
export class OpenIdConnectService {

  private userManager: UserManager = new UserManager(environment.openIdConnectSettings);
  private currentUser: User;

  userLoaded$ = new ReplaySubject<boolean>(1);

  get userAvailable(): boolean {
    return this.currentUser != null;
  }

  get user(): User {
    return this.currentUser;
  }

  constructor() {
    this.userManager.clearStaleState();

    this.userManager.events.addUserLoaded(user => {
      if (!environment.production) {
        console.log('User loaded.', user);
      }
      this.currentUser = user;
      this.userLoaded$.next(true);
    });

    this.userManager.events.addUserUnloaded((e) => {
      if (!environment.production) {
        console.log('User unloaded');
      }
      this.currentUser = null;
      this.userLoaded$.next(false);
    });

    this.userManager.events.addSilentRenewError(function(e) {
        console.log(e);
    });
  }

  triggerSignIn() {
    if (!this.userAvailable) {
      this.userManager.signinRedirect().then(function() {
        if (!environment.production) {
          console.log('Redirection to signin triggered.');
        }
      });
    }
  }

  handleCallback() {
    this.userManager.signinRedirectCallback().then(function(user) {
      if (!environment.production) {
        console.log('Callback after signin handler.', user);
      }
    });
  }

  handleSilentCallback() {
    this.userManager.signinSilentCallback().then(function(user) {
      if (!environment.production) {
        console.log('Callback after silent signin handler.', user);
      }
    });
  }

  triggerSignOut() {
    this.userManager.signoutRedirect().then(function (resp) {
      if (!environment.production) {
        console.log('Redirection to sign out triggered.', resp);
      }
    });
  }

}

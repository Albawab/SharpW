import { Component, ViewChild, ViewEncapsulation, Output, EventEmitter, OnInit } from '@angular/core';
import { NavigatorComponent } from 'navigator';
import { ModulesMenuComponent } from 'modulesMenu';
import { Router } from '@angular/router';
import { HeaderService } from 'header';
import { NavigatorMapService } from 'navigatorMap';
import { AppService } from './shared/services/app.service';
import { IConfig } from './shared/models/Iconfig';
import { OpenIdConnectService } from './shared/services/open-id-connect.service';
import { User } from 'oidc-client';
import { NavigatorTestComponent } from './navigator-test/navigator-test.component';

@Component({
  selector: 'hene-root',
  templateUrl: './app.component.html',
  styleUrls: ['./app.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class AppComponent {
  @ViewChild('navi') navigatorComponent: NavigatorComponent;
  @ViewChild('navi2') navigatorTestComponent: NavigatorTestComponent;
  @ViewChild('modulesMenu') modulesMenu: ModulesMenuComponent;
  @ViewChild('editBerichtInterface') editBerichtInterface: ModulesMenuComponent;
  // bericht: any;
  user: User;
  isSignOut: Boolean = false;

  // AS - Deze parameters vanaf de configuratie
  // config: IConfig;
  // urlNavigator = 'http://localhost:51750/swagger/api/v1/navigator/';
  // urlModules = 'http://localhost:51750/swagger/api/v1/modules/';

  constructor(private router: Router, private headerService: HeaderService,
    private navigatorMapService: NavigatorMapService, public appService: AppService,
    public openIdConnectService: OpenIdConnectService) {

      this.headerService.currentIsSignOut.subscribe(signOut => {
        this.isSignOut = signOut;
        if (this.isSignOut) {
          console.log('Sign out', this.isSignOut);
          this.openIdConnectService.triggerSignOut();
        }
      });
  }

  getNotification(data) {
    if (data) {
      // this.router.navigate(['home', data.id, data.titel]);
      // this.navigatorMapService.getNavigatorMap(this.url);
      this.navigatorMapService.navigatorItemChanged.next(data);
    }

    this.router.navigate(['home']);
  }

  openModulesMenu(data) {
    this.modulesMenu.toggleMenu();
  }

  getName(): string {
    this.user = this.openIdConnectService.user;
    if (this.user) {
        return this.user.profile.given_name + ' ' + this.user.profile.family_name;
    }
  }

  signOut(data) {
    this.openIdConnectService.triggerSignOut();
  }

}

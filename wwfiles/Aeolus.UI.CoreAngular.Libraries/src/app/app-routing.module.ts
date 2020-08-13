import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { HomeComponent } from './home/home.component';
import { AuthGuard } from './shared/guards/auth.guard';
// import { EditBerichtComponent } from './edit-bericht/edit-bericht.component';
import { BerichtResolver } from './shared/resolvers/bericht.resolver';
import { TestTxControlComponent } from './test-tx-control/test-tx-control.component';

const routes: Routes = [
  // { path: '', redirectTo: 'home', pathMatch: 'full', canActivate: [AuthGuard] },
  // { path: 'home', component:  HomeComponent, canActivate: [AuthGuard]},
  // { path: 'home/:zoekterm', component:  HomeComponent, canActivate: [AuthGuard] },
  // { path: 'home/:id/:titel', component:  HomeComponent, canActivate: [AuthGuard] },
  // { path: 'signin-oidc', loadChildren: './signin-oidc/signin-oidc.module#SigninOidcModule' },
  // { path: 'redirect-silentrenew', loadChildren: './redirect-silent-renew/redirect-silent-renew.module#RedirectSilentRenewModule' },

  { path: '', redirectTo: 'home', pathMatch: 'full', canActivate: [AuthGuard] },
  { path: 'home', component:  HomeComponent, canActivate: [AuthGuard] },
  { path: 'home/:zoekterm', component: HomeComponent },
  { path: 'home/:id/:titel', component: HomeComponent },
  { path: 'tx', component: TestTxControlComponent },
  // { path: 'editBericht/:id/:titel', component: EditBerichtComponent, resolve: { bericht: BerichtResolver } },
  { path: 'signin-oidc', loadChildren: './signin-oidc/signin-oidc.module#SigninOidcModule' },
  { path: 'redirect-silentrenew', loadChildren: './redirect-silent-renew/redirect-silent-renew.module#RedirectSilentRenewModule' },
];

@NgModule({
  imports: [RouterModule.forRoot(routes)],
  exports: [RouterModule]
})
export class AppRoutingModule { }

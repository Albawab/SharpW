import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { SigninOidcComponent } from './signin-oidc.component';

const routes: Routes = [
    {
        path: '',
        component: SigninOidcComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class SigninOidcRoutingModule {}

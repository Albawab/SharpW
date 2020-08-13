import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { SigninOidcRoutingModule } from './signin-oidc-routing.module';
import { SigninOidcComponent } from './signin-oidc.component';

@NgModule({
    imports: [CommonModule, SigninOidcRoutingModule],
    declarations: [SigninOidcComponent]
})
export class SigninOidcModule {}

import { NgModule } from '@angular/core';
import { Routes, RouterModule } from '@angular/router';
import { RedirectSilentRenewComponent } from './redirect-silent-renew.component';

const routes: Routes = [
    {
        path: '',
        component: RedirectSilentRenewComponent
    }
];

@NgModule({
    imports: [RouterModule.forChild(routes)],
    exports: [RouterModule]
})
export class RedirectSilentRenewRoutingModule {}

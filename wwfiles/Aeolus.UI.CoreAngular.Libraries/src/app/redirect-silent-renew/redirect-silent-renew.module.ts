import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';

import { RedirectSilentRenewRoutingModule } from './redirect-silent-renew-routing.module';
import { RedirectSilentRenewComponent } from './redirect-silent-renew.component';

@NgModule({
    imports: [CommonModule, RedirectSilentRenewRoutingModule],
    declarations: [RedirectSilentRenewComponent]
})
export class RedirectSilentRenewModule {}

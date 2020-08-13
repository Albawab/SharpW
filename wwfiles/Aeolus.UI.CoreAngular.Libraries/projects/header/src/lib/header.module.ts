import { NgModule } from '@angular/core';
import { HeaderComponent } from './header.component';
import { NgbModule, NgbActiveModal } from '@ng-bootstrap/ng-bootstrap';
import { DialogModule, TooltipModule } from '@syncfusion/ej2-ng-popups';
import { AutoCompleteModule, DropDownListModule } from '@syncfusion/ej2-ng-dropdowns';

@NgModule({
  imports: [
    NgbModule.forRoot(),
    DialogModule,
    TooltipModule,
    AutoCompleteModule,
    DropDownListModule
  ],
  declarations: [HeaderComponent],
  providers: [NgbActiveModal],
  exports: [HeaderComponent]
})
export class HeaderModule { }

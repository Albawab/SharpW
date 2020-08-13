import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { ModulesMenuComponent } from './modules-menu.component';
import { DialogModule, TooltipModule } from '@syncfusion/ej2-ng-popups';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    DialogModule,
    TooltipModule
  ],
  declarations: [ModulesMenuComponent],
  exports: [ModulesMenuComponent]
})
export class ModulesMenuModule { }

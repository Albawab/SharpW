import { NgModule } from '@angular/core';
import { CommonModule } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { AutoCompleteModule, DropDownListModule } from '@syncfusion/ej2-ng-dropdowns';
import { TreeViewModule, ToolbarModule, AccordionModule } from '@syncfusion/ej2-ng-navigations';
import { NavigatorComponent } from './navigator.component';
import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule ,
    TreeViewModule,
    AccordionModule,
    DropDownListModule,
    ToolbarModule,
    AutoCompleteModule,
    NgbModule.forRoot()
  ],
  declarations: [NavigatorComponent],
  exports: [NavigatorComponent]
})
export class NavigatorModule { }

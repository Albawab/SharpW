import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule  } from '@angular/common';
import { HttpClientModule } from '@angular/common/http';
import { MainLijstComponent } from './main-lijst.component';
import { ButtonModule, RadioButtonModule, CheckBoxModule } from '@syncfusion/ej2-ng-buttons';
import { ListViewModule  } from '@syncfusion/ej2-ng-lists';
import { SplitButtonModule, DropDownButtonModule } from '@syncfusion/ej2-ng-splitbuttons';
import { ContextMenuModule } from '@syncfusion/ej2-ng-navigations';

@NgModule({
  imports: [
    CommonModule,
    HttpClientModule,
    ButtonModule,
    CheckBoxModule,
    RadioButtonModule,
    ListViewModule,
    SplitButtonModule,
    ContextMenuModule,
    DropDownButtonModule
  ],
  declarations: [
    MainLijstComponent
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
  exports: [MainLijstComponent]
})
export class MainLijstModule { }

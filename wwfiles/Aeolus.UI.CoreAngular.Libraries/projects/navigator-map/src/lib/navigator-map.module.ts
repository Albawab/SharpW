import { NgModule, CUSTOM_ELEMENTS_SCHEMA } from '@angular/core';
import { CommonModule } from '@angular/common';
import { TreeViewModule, ToolbarModule, ContextMenuModule, AccordionModule } from '@syncfusion/ej2-ng-navigations';
import { ButtonModule, RadioButtonModule, CheckBoxModule } from '@syncfusion/ej2-ng-buttons';
import { AutoCompleteModule, DropDownListModule } from '@syncfusion/ej2-ng-dropdowns';
import { ListViewModule } from '@syncfusion/ej2-ng-lists';
import { SplitButtonModule } from '@syncfusion/ej2-ng-splitbuttons';
import { DropDownButtonModule } from '@syncfusion/ej2-ng-splitbuttons';
import { DialogModule, TooltipModule } from '@syncfusion/ej2-ng-popups';
import { ToastModule } from '@syncfusion/ej2-ng-notifications';
import { GridModule, ToolbarService, SortService, FilterService, PageService,
  VirtualScrollService, ExcelExportService } from '@syncfusion/ej2-ng-grids';

import { NavigatorMapComponent } from './navigator-map.component';
import { PreviewItemComponent } from './preview-item/preview-item.component';
import { NavigatorLijstItemsComponent } from './navigator-lijst-items/navigator-lijst-items.component';
import { ActiesComponent } from './acties/acties.component';
import { BerichtPreviewComponent } from './components/bericht-preview/bericht-preview.component';
import { KlantPreviewComponent } from './components/klant-preview/klant-preview.component';
// import { EditBerichtComponent } from './components/edit-bericht/edit-bericht.component';

@NgModule({
  imports: [
    CommonModule,
    TreeViewModule,
    ToolbarModule,
    ContextMenuModule,
    AccordionModule,
    ButtonModule,
    RadioButtonModule,
    CheckBoxModule,
    AutoCompleteModule,
    DropDownListModule,
    ListViewModule,
    SplitButtonModule,
    DropDownButtonModule,
    DialogModule,
    TooltipModule,
    ToastModule,
    GridModule
  ],
  declarations: [
    NavigatorMapComponent,
    PreviewItemComponent,
    NavigatorLijstItemsComponent,
    ActiesComponent,
    BerichtPreviewComponent,
    KlantPreviewComponent,
    // EditBerichtComponent
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
  providers: [
    VirtualScrollService,
    ToolbarService,
    SortService,
    FilterService,
    PageService,
    ExcelExportService
  ],
  exports: [NavigatorMapComponent]
})
export class NavigatorMapModule { }

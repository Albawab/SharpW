import { BrowserModule } from '@angular/platform-browser';
import { ReactiveFormsModule } from '@angular/forms';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { NgModule, CUSTOM_ELEMENTS_SCHEMA, APP_INITIALIZER  } from '@angular/core';

import { AppRoutingModule } from './app-routing.module';
import { AppComponent } from './app.component';

import { NgbModule } from '@ng-bootstrap/ng-bootstrap';

import { NavigatorModule } from 'navigator';
import { ModulesMenuModule } from 'modulesMenu';
import { MainLijstModule, ILijstMapper } from 'MainLijst';
import { HeaderModule } from 'header';
import { fakeBackendProvider } from './shared/services/fake.service';
import { AppService } from './shared/services/app.service';

import { ButtonModule, RadioButtonModule, CheckBoxModule } from '@syncfusion/ej2-ng-buttons';
import { AutoCompleteModule, DropDownListModule, MultiSelectModule, CheckBoxSelectionService } from '@syncfusion/ej2-ng-dropdowns';
import { TreeViewModule, ToolbarModule, ContextMenuModule, AccordionModule } from '@syncfusion/ej2-ng-navigations';
import { ListViewModule  } from '@syncfusion/ej2-ng-lists';
import { SplitButtonModule } from '@syncfusion/ej2-ng-splitbuttons';
import { DropDownButtonModule } from '@syncfusion/ej2-ng-splitbuttons';
import { DialogModule, TooltipModule } from '@syncfusion/ej2-ng-popups';
import { ToastModule } from '@syncfusion/ej2-ng-notifications';
import { GridModule, VirtualScrollService } from '@syncfusion/ej2-ng-grids';
import { DatePickerModule } from '@syncfusion/ej2-ng-calendars';
import { RichTextEditorModule, ToolbarService, LinkService, ImageService, HtmlEditorService } from '@syncfusion/ej2-ng-richtexteditor';
import { UploaderComponent } from '@syncfusion/ej2-ng-inputs';

import { HomeComponent } from './home/home.component';
import { NavigatorMapModule, INavigatorMapMapper } from 'navigatorMap';
import { RightSidebaarModule } from 'rightSidebaar';
import { NavigatorMapMapper } from './shared/mappers/NavigatorMapMapper';
import { HttpClientModule, HTTP_INTERCEPTORS } from '@angular/common/http';
import { ErrorInterceptor } from './shared/interceptors/error-interceptor';
import { AuthGuard } from './shared/guards/auth.guard';
import { EditBerichtComponent } from './edit-bericht/edit-bericht.component';
import { EditKlantcontactComponent } from './edit-klantcontacten/edit-klantcontact.component';
import { loadCldr, setCulture, setCurrencyCode, enableRipple, L10n } from '@syncfusion/ej2-base';
import { AddAuthorizationHeaderInterceptor } from './shared/interceptors/add-authorization-header-interceptor';
import { NavigatorTestComponent } from './navigator-test/navigator-test.component';
import { TestTxControlComponent } from './test-tx-control/test-tx-control.component';

declare let require: any;
loadCldr(
  require('../../node_modules/cldr-data/supplemental/numberingSystems.json'),
  require('../../node_modules/cldr-data/main/nl/ca-gregorian.json'),
  require('../../node_modules/cldr-data/main/nl/currencies.json'),
  require('../../node_modules/cldr-data/main/nl/numbers.json'),
  require('../../node_modules/cldr-data/main/nl/timeZoneNames.json')
);

setCulture('nl');
setCurrencyCode('EUR');
enableRipple(true);

// TODO: AS - Location tekst in een apparte json bestand
L10n.load({
  'nl': {
      'grid': {
          'EmptyRecord': 'Geen records gevonden',
          'GroupDropArea': 'Sleep de kolom hierin om te groeperen op de gesleepte kolom',
          'UnGroup': 'Klik hier om opheffen',
          'EmptyDataSourceError':
            'DataSource mag niet leeg bij de eerste lading, omdat kolommen worden gegenereerd uit dataSource in AutoGenerated Column Grid',
          'Item': 'Item',
          'Items': 'items',
          'Search': 'Zoeken',
          'Columnchooser': 'Kolommen',
          'ChooseColumns': 'Kies Kolom',
          'OKButton': 'OK',
          'CancelButton': 'Annuleer',
          'Matchs': 'Geen resultaten gevonden',
          'FilterButton': 'Filter',
          'ClearButton': 'Wissen',
          'StartsWith': 'Begint met',
          'EndsWith': 'Eindigt met',
          'Contains': 'Bevat',
          'Equal': 'Gelijk',
          'NotEqual': 'Niet Gelijk',
          'LessThan': 'Minder dan',
          'LessThanOrEqual': 'Minder dan of gelijk',
          'GreaterThan': 'Groter dan',
          'GreaterThanOrEqual': 'Groter dan of gelijk aan',
          'ChooseDate': 'Kies een datum',
          'EnterValue': 'Voer de waarde in'
      },
      'pager': {
          'currentPageInfo': '{0} van {1} pagina\'s',
          'totalItemsInfo': '({0} Items)',
          'firstPageTooltip': 'Naar de eerste pagina',
          'lastPageTooltip': 'Naar de laatste pagina',
          'nextPageTooltip': 'Naar de volgende pagina',
          'previousPageTooltip': 'Naar de vorige pagina',
          'nextPagerTooltip': 'Naar de volgende pager',
          'previousPagerTooltip': 'Naar de vorige pager'
      },
      'excelFilter': {
        'Search': 'Zoeken',
        'SelectAll': 'Selecteer alles',
        'Blanks': 'Blanks',
        'ClearFilter': 'Filter wissen',
        'NumberFilter': 'Getalfilters',
        'TextFilter': 'Tekstfilters',
        'DateFilter': 'Datumfilters',
        'MatchCase': 'Match Case',
        'Equal': 'Gelijk',
        'NotEqual': 'Niet Gelijk',
        'LessThan': 'Minder dan',
        'LessThanOrEqual': 'Minder dan of gelijk',
        'GreaterThan': 'Groter dan',
        'GreaterThanOrEqual': 'Groter dan of gelijk',
        'Between': 'Tussen',
        'CustomFilter': 'Custom Filter',
        'StartsWith': 'Begint met',
        'EndsWith': 'Eindigt met',
        'Contains': 'Bevat',
        'OK': 'OK',
        'Cancel': 'Annuleren',
        'CustomFilterPlaceHolder': 'Voer de waarde in',
        'CustomFilterDatePlaceHolder': 'Kies een datum',
        'AND': 'EN',
        'OR': 'OF',
        'ShowRowsWhere': 'Toon rijen waar:'
      },
      'dropdowns': {
        'noRecordsTemplate': 'Geen sugesties gevonden',
    }
  }
});


export function init_app(firstLoadService: AppService ) {
  return () => firstLoadService.init();
}
@NgModule({
  declarations: [
    AppComponent,
    HomeComponent,
    EditBerichtComponent,
    EditKlantcontactComponent,
    NavigatorTestComponent,
    TestTxControlComponent,
    UploaderComponent
  ],
  imports: [
    BrowserModule,
    ReactiveFormsModule,
    BrowserAnimationsModule,
    HttpClientModule,
    AppRoutingModule,
    AutoCompleteModule,
    DropDownListModule,
    ToolbarModule,
    TreeViewModule,
    ListViewModule,
    SplitButtonModule,
    DropDownButtonModule,
    ButtonModule,
    RadioButtonModule,
    CheckBoxModule,
    ContextMenuModule ,
    DialogModule,
    TooltipModule,
    ToastModule,
    GridModule,
    AccordionModule,
    DatePickerModule,
    MultiSelectModule,
    RichTextEditorModule,
    NavigatorModule,
    ModulesMenuModule,
    MainLijstModule,
    HeaderModule,
    NavigatorMapModule,
    RightSidebaarModule,
    NgbModule.forRoot()
  ],
  schemas: [ CUSTOM_ELEMENTS_SCHEMA ],
  providers: [
    AuthGuard,
    VirtualScrollService,
    CheckBoxSelectionService,
    ToolbarService, LinkService, ImageService, HtmlEditorService,
    fakeBackendProvider,
    { provide: INavigatorMapMapper, useClass: NavigatorMapMapper },
    { provide: HTTP_INTERCEPTORS, useClass: AddAuthorizationHeaderInterceptor, multi: true },
    { provide: HTTP_INTERCEPTORS, useClass: ErrorInterceptor, multi: true },
    AppService,
    { provide: APP_INITIALIZER, useFactory: init_app, deps: [AppService], multi: true }
  ],
  bootstrap: [AppComponent]
})
export class AppModule {}

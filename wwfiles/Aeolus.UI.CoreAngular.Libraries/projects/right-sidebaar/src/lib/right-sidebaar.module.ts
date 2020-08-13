import { NgModule } from '@angular/core';
import { BrowserModule } from '@angular/platform-browser';
import { BrowserAnimationsModule } from '@angular/platform-browser/animations';
import { DialogModule, TooltipModule } from '@syncfusion/ej2-ng-popups';
import { ToastModule } from '@syncfusion/ej2-ng-notifications';
import { RightSidebaarComponent } from './right-sidebaar.component';
import { EventsComponent } from './events/events.component';

@NgModule({
  imports: [
    BrowserModule,
    BrowserAnimationsModule,
    DialogModule,
    TooltipModule,
    ToastModule
  ],
  declarations: [RightSidebaarComponent, EventsComponent],
  exports: [RightSidebaarComponent, EventsComponent]
})
export class RightSidebaarModule { }

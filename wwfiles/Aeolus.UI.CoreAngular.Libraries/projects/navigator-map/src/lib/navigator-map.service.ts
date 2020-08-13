import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { INavigatorMapMapper } from './models/INavigatorMapMapper';
import { Subject, Observable, BehaviorSubject } from 'rxjs';
import { NavigatorItem } from 'navigator/public_api';
import { NavigatorMap } from './models/navigatorMap';
import { ConfirmSubActie, OpenSubActie, EditSubActie } from './models/subActie';
import { Router } from '@angular/router';

@Injectable({
  providedIn: 'root'
})
export class NavigatorMapService {
  navigatorItemChanged = new Subject<NavigatorItem>();
  geselecteerdItemsChanged = new Subject<any>();
  itemChanged = new Subject<any>();
  // showEditUserInterface = new BehaviorSubject<Boolean>(false);

  constructor(private _http: HttpClient, private mapper: INavigatorMapMapper, private router: Router) {}

  getNavigatorMap(url): Observable<NavigatorMap> {
    return this.mapper.GetNavigatorMapFromUrl(url);
  }

  getLijstItems(url: string, soort?: string, select?: string, filter?: string, order?: string, group?: string ): any {
    url += '?$top=500';

    if (select) {
      url += '&$select=' + select;
    }
    if (filter) {
      url += '&$filter=' + filter;
    }
    if (order) {
      url += '&$orderby=' + order;
    }
    if (group) {
      url += '&$groupby=' + group;
    }

    return this.mapper.GetItemsFromUrl(url, soort);
  }

  getPreviewItem(url, soort): any {
    return this.mapper.GetItemFromUrl(url, soort);
  }

  getItemsFromUrl(url: string): Observable<any> {
    return this._http.get<any>(url);
  }

  processSubActie(subActie, item) {
    // uitvoeren op enkele of alles?
    let result = 'Failed';
    switch (subActie.soort) {
      case 'confirm':
        result = this.onProcessConfirmActie(subActie, item);
        break;
      case 'open':
        result = this.onProcessOpenActie(subActie, item);
        break;
      case 'apicall':
        result = this.onProcessCallApiCommand(subActie, item);
        break;
      case 'refresh':
        result = this.onProcessRefreshActie(subActie, item);
        break;
      case 'edit':
        result = this.onProcessEditActie(subActie, item);
        break;
      case 'popup':
        result = this.onProcessPopupActie(subActie, item);
        break;
    }

    // wat moet ik doen bij een failed?
    // zodat ik kan bepalen of de failed negeert moet worden
    if (result === 'Failed') {
      return subActie.returnFailedResult;
    }
    return subActie.returnSuccesResult;
  }

  private onProcessConfirmActie(subActie, item) {
    // subactie is nu van type ConfirmActie
    const confirmActie = subActie as ConfirmSubActie;
    if (window.confirm(this.mergeCommandWithItem(confirmActie.vraag, item))) {
      return confirmActie.returnSuccesResult;
    } else {
      return confirmActie.returnFailedResult;
    }
  }

  private onProcessEditActie(subActie, item) {

    this.mapper.OpenInterface(subActie, item);
    // this.showEditUserInterface.next(true);

    // this.router.navigate([editActie.path, item.id, item.titel])
    // .catch(error => {
    //   console.log(error);
    //   return error;
    // });
    return 'Ok';
  }

  private onProcessOpenActie(subActie, item) {
    const openActie = subActie as OpenSubActie;
    window.open(this.mergeCommandWithItem(openActie.url, item), openActie.target);
    return 'Ok';
  }

  private onProcessCallApiCommand(subActie, item) {
    return '';
  }

  private onProcessRefreshActie(subActie, item) {
    return '';
  }

  private onProcessPopupActie(subActie, item) {
    this.mapper.OpenInterface(subActie, item);
    return 'Ok';
  }

  /** Helper functies */
  private mergeCommandWithItem(command, item) {
    if (command) {
      const itemsToReplace = command.match(/\{.+?\}/g) || [];

      for (let i = 0; i > itemsToReplace.length; i++) {
        const val = item.itemsToReplace[i];
        command = command.replace(itemsToReplace, val);
      }
      command = command.replace('{titel}', item.titel);
      command = command.replace('{id}', item.id);
    }
    return command;
  }
}

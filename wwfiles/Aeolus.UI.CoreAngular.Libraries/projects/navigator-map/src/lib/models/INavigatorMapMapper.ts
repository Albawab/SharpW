import { Injectable } from '@angular/core';
import { Observable, BehaviorSubject } from 'rxjs';
import { NavigatorMap } from './navigatorMap';
import { LijstItem } from './lijstItem';
import { PreviewItem } from './previewItem';

@Injectable()
export abstract class INavigatorMapMapper   {

  abstract GetNavigatorMapFromUrl(url: string): Observable<NavigatorMap>;

  abstract GetItemsFromUrl(url: string, soort?: string, select?: string,
    filter?: string, order?: string, group?: string): Observable<LijstItem[]>;

  abstract GetItemFromUrl(url: string, soort?: string): Observable<PreviewItem>;

  abstract OpenInterface(subActie: any, item: any);
}

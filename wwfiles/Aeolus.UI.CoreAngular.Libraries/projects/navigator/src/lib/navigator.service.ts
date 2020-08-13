import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { NavigatorItem } from './models/navigatorItem';

@Injectable({
  providedIn: 'root'
})
export class NavigatorService {

  constructor(private _http: HttpClient) {}

  getNavigator(url): any {
    return this._http.get<NavigatorItem[]>(url);
  }

}

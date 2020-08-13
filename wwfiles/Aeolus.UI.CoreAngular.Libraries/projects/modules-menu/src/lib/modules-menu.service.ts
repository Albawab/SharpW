import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
import { ModuleItem } from './models/moduleItem';

@Injectable({
  providedIn: 'root'
})
export class ModulesMenuService {

  constructor(private _http: HttpClient) {}

  getMenuItems(url): any {
    return this._http.get<ModuleItem[]>(url);
  }
}

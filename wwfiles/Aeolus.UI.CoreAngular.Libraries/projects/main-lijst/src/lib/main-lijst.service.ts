import { Injectable } from '@angular/core';
import { HttpClient } from '@angular/common/http';
// import { LijstItem } from './models/lijstItem';
import { ILijstMapper } from './models/ILijstMapper';

// import { map } from 'rxjs/operators';
// import { Observable } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class MainLijstService {
  // items: LijstItem[] = [];

  constructor(private _http: HttpClient, private mapper: ILijstMapper) {}

  getLijstItems(url): any {

    // AS - get items from the mapper, de applicatie bepaald wat moet hier geven
    return this.mapper.GetItemsFromUrl(url);

    // return this._http.get<LijstItem[]>(url);

    // return this._http.get<Klant[]>(url).pipe(map(res => {
    //  // this.items.push({ id: res[0].id, titel: res.naam, })
    // }));

    // const klanten = this._http.get<any>(url);

    // klanten.forEach( (klant) => {
    //   this.items.push({ id: klant.id, titel: klant.naam,  });
    // });

    // return this.items;

    // return this._http.get<any[]>(url);
  }
}

import { Injectable } from '@angular/core';
import { LijstItem, ILijstMapper } from 'MainLijst/public_api';
import { of, Observable, BehaviorSubject } from 'rxjs';
import { HttpClient } from '@angular/common/http';
import { map } from 'rxjs/operators';
import { Klant } from '../models/klant';
import { Bericht, Bericht2 } from '../models/bericht';
import { INavigatorMapMapper, NavigatorMap, NavigatorMapService } from 'navigatorMap';
import { PreviewItem, SoortItem } from 'navigatorMap';
import { AppService } from '../services/app.service';

@Injectable({
  providedIn: 'root'
})
export class NavigatorMapMapper implements INavigatorMapMapper {

  items: LijstItem[] = [];
  item: PreviewItem;
  // showEditBerichtUserInterface = new BehaviorSubject<Boolean>(false);

  constructor(private _http: HttpClient, private appService: AppService,
    private navigatorMapService: NavigatorMapService) {}

  GetNavigatorMapFromUrl(url: string): Observable<NavigatorMap> {
    return this._http.get<NavigatorMap>(url);
  }

  GetItemsFromUrl(url: string, soort?: string): Observable<LijstItem[]> {
    return this._http.get<any>(url)
    .pipe(map((response) => {
        switch (soort) {
          case 'Bericht': {
            return this.mapApiToModelBericht(response);
          }
          case 'Klant': {
            return this.mapApiToModelKlant(response);
          }
          case 'Bericht2': {
            return this.mapApiToModelBericht2(response.value);
          }
          default: {
            return this.mapApiToModelBericht(response);
          }
        }
      }
    ));
  }

  GetItemFromUrl(url: string, soort?: string): Observable<PreviewItem> {
    return this._http.get<any>(url)
    .pipe(map( (response) => {
        switch (soort) {
          case 'Bericht': {
            return this.mapApiToPreviewItem(response);
          }
          case 'Klant': {
            return this.mapApiKlantToPreviewItem(response);
          }
          case 'Bericht2': {
            return this.mapApiBerichtToPreviewItem(response);
          }
          default: {
            return this.mapApiToPreviewItem(response);
          }
        }
      }
    ));
  }

  OpenInterface(action: any, item: any) {
    console.log(action);
    console.log(item);
    if (action.path === 'editBericht') {
      this.appService.showEditBerichtUserInterface.next(true);
    } else if (action.path === 'editKlantcontact') {
      this.appService.showEditklantcontactUserInterface.next(true);
    }
  }

  private mapApiToPreviewItem(bericht: Bericht): PreviewItem {
    this.item = new PreviewItem();
    this.item.id = bericht.id;
    this.item.titel = bericht.titel;
    this.item.omschrijving = bericht.omschrijving;
    this.item.uri = bericht.uri;
    this.item.datum = bericht.datum;
    this.item.extras = bericht.extras;
    return this.item;
  }


  private mapApiKlantToPreviewItem(klant: Klant): PreviewItem {
    this.item = new PreviewItem();
    this.item.id = klant.id;
    this.item.titel = klant.naam;
    this.item.omschrijving = klant.omschrijving;
    this.item.uri = klant.uri;
    this.item.datum = klant.geboortedatum;
    this.item.extras = klant.extras;
    this.item.soort = SoortItem.Klant;
    // this.item.icon = this.getItemIcon(this.item.soort);
    return this.item;
  }

  private mapApiBerichtToPreviewItem(res: any): PreviewItem {
    try {
      this.item = new PreviewItem();
      this.item.id = res.value[0].Id;
      this.item.titel = res.value[0].Volgnr.toString();
      // this.item.omschrijving = bericht.omschrijving;
      // this.item.uri = '';
      this.item.datum = res.value[0].DatumAangemaakt;
      this.item.soort = SoortItem.Bericht; // AS - voor nu hardcode
      // this.item.icon = this.getItemIcon(this.item.soort);
      this.item.onderdelen = [
        { id: 'onderdeel1', titel: 'Regels',  uri: 'http://bericht/regels', acties: '', soort: 'grid'},
        { id: 'onderdeel2', titel: 'Test 2',  uri: 'http://bericht/regels', acties: '', soort: 'grid'}
      ];
      this.item.acties = [
        {id: 'actie2',
          cssClass: 'e-btn e-small e-flat e-info actie-item',
          text: 'Open bericht confirm',
          suffixIcon: 'fas fa-long-arrow-right',
          soort: 'openItem',
          baseUrl: 'http://testurl/',
          uitvoerenOpAantal: 'enkel',
          directUitvoeren: true,
          subActies: [
            { id: '1', type: 'confirmActie', voerUitOpAlleItems: false, soort: 'confirm',
              returnFailedResult: 'Failed', returnSuccesResult: 'Succes',
              vraag: 'Weet u zeker dat u {titel} wilt verwijderen?' },
            { id: '2', type: 'openActie', voerUitOpAlleItems: false, soort: 'open',
              url: 'https://test.nl/{id}/{titel}/', target: '_blank',
              returnFailedResult: 'Failed', returnSuccesResult: 'Succes' }
          ]
        }];
      return this.item;
    } catch (err) {
      if (err.message) {
        return err.message;
      } else {
        return err;
      }
    }
  }

  private mapApiToModelBericht(berichten: Bericht[]): LijstItem[] {
    this.items = [];
    berichten.forEach( res => {
      this.items.push({
        id: res.id,
        titel: res.titel,
        omschrijving: res.omschrijving,
        uri: res.uri,
        datum: res.datum,
        extras: res.extras
      });
    });
    return this.items;
  }

  private mapApiToModelKlant(klanten: Klant[]): LijstItem[] {
    this.items = [];
    klanten.forEach( res => {
      this.items.push({
        id: res.id,
        titel: res.naam,
        omschrijving: res.omschrijving,
        uri: res.uri,
        datum: res.geboortedatum,
        extras: res.extras
      });
    });
    return this.items;
  }

  private mapApiToModelBericht2(berichten: Bericht2[]): LijstItem[] {
    this.items = [];
    berichten.forEach( res => {
      res.extras = res.extras || [];
      this.items.push({
        id: res.Id,
        titel: res.Volgnr.toString(),
        datum: res.DatumAangemaakt,
        extras: res.extras.concat([
          { key: 'Status', value: res.CBerichtStatus.toString() },
          { key: 'Prioriteit', value: res.CPrioriteit.toString() }
        ])
      });
    });
    return this.items;
  }
}

import { Injectable } from '@angular/core';
import { HttpInterceptor, HttpResponse, HttpRequest, HttpHandler, HttpEvent, HTTP_INTERCEPTORS } from '@angular/common/http';
import { Observable, of, throwError } from 'rxjs';
import { NavigatorItem } from 'projects/navigator/src/lib/models/navigatorItem';
import { ModuleItem } from 'projects/modules-menu/src/lib/models/moduleItem';
import { LijstItem, NavigatorMap, PreviewItem, Onderdeel } from 'navigatorMap';
import { Klant } from '../models/klant';
// import { LijstItem, NavigatorMap } from 'MainLijst/public_api';
// import { NavigatorMap } from 'navigatorMap/lib/models/NavigatorMap';

@Injectable({
  providedIn: 'root'
})
export class FakeService implements HttpInterceptor  {

  constructor() { }

  intercept(request: HttpRequest<any>, next: HttpHandler): Observable<HttpEvent<any>> {
    // Navigator
    const navidatorItems: NavigatorItem[] = JSON.parse(localStorage.getItem('navidatorItems')) || [];

    // AS - specifieke items
    const favorieten = new NavigatorItem('p1', 'Favorieten ');
    favorieten.hasChildren = true;
    favorieten.expanded = true;
    favorieten.url = '#';
    favorieten.actions = [
      { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' }
    ];
    navidatorItems.push(favorieten);

    const inbox = new NavigatorItem('1', 'Inbox ');
    inbox.favorite = true;
    inbox.uri = 'http://getNavigatorMap/navigatorMap/1';
    inbox.parentID = favorieten.id;
    inbox.actions = [
      { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' }
    ];
    navidatorItems.push(inbox);

    // for (let i = 1; i < 5; i++) {
    //   const item = new NavigatorItem(i.toString(), 'Test ' + i);
    //   item.parentID = favorieten.id;
    //   item.favorite = true;

    //   if ( i === 1 ) {
    //     // item.status = 1;
    //     item.hasChildren = true;
    //     const item2 = new NavigatorItem('c-' + i, 'Child ' + i);
    //     item2.parentID = item.id;
    //     // item2.status = 1;
    //     item2.favorite = true;
    //     item2.actions = [
    //       { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
    //       { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
    //       { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
    //     ];
    //     navidatorItems.push(item2);
    //   }

    //   item.actions = [
    //     { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
    //     { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
    //     { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
    //   ];
    //   navidatorItems.push(item);
    // }

    const alleMappen = new NavigatorItem('p2', 'Alle mappen ');
    alleMappen.hasChildren = true;
    alleMappen.expanded = true;
    alleMappen.url = '#';
    alleMappen.actions = [
      { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' }
    ];
    navidatorItems.push(alleMappen);

    for (let i = 1; i < 5; i++) {
      const item = new NavigatorItem('pc-' + i, 'Test ' + i);
      item.parentID = alleMappen.id;
      item.favorite = false;
      item.uri = 'http://getNavigatorMap/navigatorMap/2';

      if ( i === 1 ) {
        // item.status = 1;
        item.hasChildren = true;
        const item2 = new NavigatorItem('c-' + i, 'Child ' + i);
        item2.parentID = item.id;
        // item2.status = 1;
        item2.uri = 'http://getNavigatorMap/navigatorMap/1';
        item2.favorite = false;
        item2.actions = [
          { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
          { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
          { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
        ];
        navidatorItems.push(item2);
      }

      item.actions = [
        { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
        { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
        { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
      ];
      navidatorItems.push(item);
    }

    const itemUrl = new NavigatorItem('12345', 'Ga naar Google');
    itemUrl.url = 'https://www.google.nl';
    navidatorItems.push(itemUrl);

    // end AS start - specifieke items

    // if (navidatorItems.length === 0 ) {

    //   for (let i = 1; i < 10; i++) {
    //     const item = new NavigatorItem(i.toString(), 'Test ' + i);

    //     if (i % 5 === 0 || i === 1 ) {
    //       // item.status = 1;
    //       item.hasChildren = true;
    //       const item2 = new NavigatorItem('c-' + i, 'Child ' + i);
    //       item2.parentID = item.id;
    //       // item2.status = 1;
    //       item.favorite = true;
    //       item2.actions = [
    //         { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
    //         { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
    //         { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
    //       ];
    //       navidatorItems.push(item2);
    //     } else {
    //       // item.status = 2;
    //       item.favorite = false;
    //     }

    //     item.actions = [
    //       { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
    //       { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
    //       { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
    //     ];
    //     navidatorItems.push(item);
    //   }
    // }

    if (request.url.endsWith('/navigator/') && request.method === 'GET') {
      // check for fake auth token in header and return users if valid, this security is implemented server side in a real application
      // if (request.headers.get('Authorization') === 'Bearer fake-jwt-token') {
          return of(new HttpResponse({ status: 200, body: navidatorItems }));
      // } else {
      //     // return 401 not authorised if token is null or invalid
      //     return throwError({ error: { message: 'Unauthorised' } });
      // }
    }


    // Modules
    const modules: ModuleItem[] = [
      {id: '1', titel: 'Klanten', icon: 'fas fa-users', href: 'Klanten'},
      {id: '2', titel: 'Organisaties', icon: 'fas fa-building', href: 'Organisaties'},
      {id: '3', titel: 'Voorzieningen', icon: 'fas fa-hands-helping', href: 'Voorzieningen'},
      {id: '4', titel: 'Werkprocessen', icon: 'fas fa-project-diagram', href: 'Werkprocessen'},
      {id: '5', titel: 'Berichten', icon: 'far fa-paper-plane', href: 'Berichten'},
      {id: '6', titel: 'Financiën', icon: 'far fa-chart-line', href: 'Financiën'},
      {id: '7', titel: 'Catalogussen', icon: 'far fa-book', href: 'Catalogussen'},
      {id: '8', titel: 'Dashboard', icon: 'far fa-columns', href: 'Dashboard'}
    ];

    // const modulesItems = modules.concat(modules, modules, modules, modules, modules, modules);

    if (request.url.endsWith('/modules/') && request.method === 'GET') {
      return of(new HttpResponse({ status: 200, body: modules }));
    }

    // NavigatorMap 1
    const navigatorMap: NavigatorMap = {
         'titel': 'Berichten Informatie',
         'omschrijving': 'omschrijving test',
         'filter': 'filter test',
         'select': 'select test',
         'orderBy': 'orderBy test',
         'groupBy': 'groupBy test',
         'soortInhoud': 'Bericht2',
         'filterOptions': [
            { 'titel': 'Alles', 'value': null, 'selected': true },
            { 'titel': 'Status 0', 'value': 'CBerichtStatus eq 0' },
            { 'titel': 'Status 99', 'value': 'CBerichtStatus eq 99' },
          ],
         'orderByOptions': [
            { 'titel': 'Geen', 'value': null, 'selected': true },
            { 'titel': 'Aangemaakt datum asc', 'value': 'DatumAangemaakt asc' },
            { 'titel': 'Aangemaakt datum desc', 'value': 'DatumAangemaakt desc' },
            { 'titel': 'Volgnr asc', 'value': 'Volgnr asc' },
            { 'titel': 'Volgnr desc', 'value': 'Volgnr desc' }
          ],
         'groupByOptions': [
           { 'titel': 'Prioriteit', 'value': 'CPrioriteit' }
         ],
         'definitie': { 'uri': 'http://localhost:49800/odata/Berichten/' },
         'navigatorMapActies': [
          { 'id': 'actie1',
            'cssClass': 'e-btn e-small e-flat e-info actie-item',
            'text': 'Open bericht',
            'prefixIcon': 'far fa-save',
            'soort': 'openItems',
            'baseUrl': 'http://testurl/',
            'uitvoerenOpAantal': 'enkel',
            'directUitvoeren': true,
            'subActies': [
              { 'type': 'openActie', 'voerUitOpAlleItems': false, 'soort': 'open',
              'url': 'https://test.nl/{id}/{titel}/', 'target': '_blank',
              'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
             }
            ]
           },
           {'id': 'actie2',
           'cssClass': 'e-btn e-small e-flat e-info actie-item',
           'text': 'Open bericht confirm',
           'suffixIcon': 'fas fa-long-arrow-right',
           'soort': 'openItem',
           'baseUrl': 'http://testurl/',
           'uitvoerenOpAantal': 'enkel',
           'directUitvoeren': true,
           'subActies': [
             { 'type': 'confirmActie', 'voerUitOpAlleItems': false, 'soort': 'confirm',
                'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
                'vraag': 'Weet u zeker dat u {titel} wilt verwijderen?' },
             { 'type': 'openActie', 'voerUitOpAlleItems': false, 'soort': 'open',
               'url': 'https://test.nl/{id}/{titel}/', 'target': '_blank',
               'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes' }
           ]
          },
          { 'id': 'actie3',
            'cssClass': 'e-btn e-small e-flat e-info actie-item',
            'text': 'Edit bericht',
            'prefixIcon': 'far fa-pen',
            'soort': 'editItems',
            'baseUrl': 'http://testurl/',
            'uitvoerenOpAantal': 'enkel',
            'directUitvoeren': true,
            'subActies': [
            { 'type': 'editActie', 'voerUitOpAlleItems': false, 'soort': 'popup',
              'path': 'editBericht',
              'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
             }
            ]
           },
           { 'id': 'actie4',
            'cssClass': 'e-btn e-small e-flat e-info actie-item',
            'text': 'Open TxControl',
            'prefixIcon': 'far fa-save',
            'soort': 'openItems',
            'baseUrl': 'http://localhost:4200/tx/',
            'uitvoerenOpAantal': 'enkel',
            'directUitvoeren': true,
            'subActies': [
              { 'type': 'openActie', 'voerUitOpAlleItems': false, 'soort': 'open',
              'url': 'http://localhost:4200/tx/', 'target': '_blank',
              'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
             }
            ]
           }
        ]
      };

    if (request.url.endsWith('/navigatorMap/1') && request.method === 'GET') {
      return of(new HttpResponse({ status: 200, body: navigatorMap }));
    }
    // NavigatorMap 2
    const navigatorMap2: NavigatorMap = {
      titel: 'Klanten Informatie 2', omschrijving: 'omschrijving test', filter: 'filter test', select: 'select test',
      orderBy: 'orderBy test', groupBy: 'groupBy test', soortInhoud: 'Klant',
      filterOptions: [ { titel: 'filterOptions id', value: 'filterOptions text' } ],
      orderByOptions: [ { titel: 'orderByOptions id', value: 'orderByOptions text' } ],
      groupByOptions: [ { titel: 'groupByOptions id', value: 'groupByOptions text' } ],
      definitie: {uri: 'http://get/lijst/' },
      'navigatorMapActies': [
      { 'id': 'actie1',
        'cssClass': 'e-btn e-small e-flat e-info actie-item',
        'text': 'Open klantcontact',
        'prefixIcon': 'far fa-save',
        'soort': 'openItems',
        'baseUrl': 'http://testurl/',
        'uitvoerenOpAantal': 'enkel',
        'directUitvoeren': true,
        'subActies': [
          { 'type': 'openActie', 'voerUitOpAlleItems': false, 'soort': 'open',
          'url': 'https://test.nl/{id}/{titel}/', 'target': '_blank',
          'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
          }
        ]
        },
        {'id': 'actie2',
        'cssClass': 'e-btn e-small e-flat e-info actie-item',
        'text': 'Open klantconatct confirm',
        'suffixIcon': 'fas fa-long-arrow-right',
        'soort': 'openItem',
        'baseUrl': 'http://testurl/',
        'uitvoerenOpAantal': 'enkel',
        'directUitvoeren': true,
        'subActies': [
          { 'type': 'confirmActie', 'voerUitOpAlleItems': false, 'soort': 'confirm',
            'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
            'vraag': 'Weet u zeker dat u {titel} wilt verwijderen?' },
          { 'type': 'openActie', 'voerUitOpAlleItems': false, 'soort': 'open',
            'url': 'https://test.nl/{id}/{titel}/', 'target': '_blank',
            'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes' }
        ]
      },
      { 'id': 'actie3',
        'cssClass': 'e-btn e-small e-flat e-info actie-item',
        'text': 'Edit klantcontact',
        'prefixIcon': 'far fa-pen',
        'soort': 'editItems',
        'baseUrl': 'http://testurl/',
        'uitvoerenOpAantal': 'enkel',
        'directUitvoeren': true,
        'subActies': [
            { 'type': 'editActie', 'voerUitOpAlleItems': false, 'soort': 'popup',
              'path': 'editKlantcontact',
              'returnFailedResult': 'Failed', 'returnSuccesResult': 'Succes',
            }
          ]
        }
      ]
   };

    if (request.url.endsWith('/navigatorMap/2') && request.method === 'GET') {
      return of(new HttpResponse({ status: 200, body: navigatorMap2 }));
    }


    // LijstItems
    const lijstItems: Klant[] = [
      {id: '1', naam: 'test 1', uri: 'http://test.nl/klant(1)/klantPreview',
        omschrijving: 'test 1 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '2', naam: 'test 2', uri: 'http://test.nl/klant(2)/klantPreview',
        omschrijving: 'test 2 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '3', naam: 'test 3', uri: 'http://test.nl/klant(3)/klantPreview',
        omschrijving: 'test 3 kdsh sihih ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '4', naam: 'test 4', uri: 'http://test.nl/klant(4)/klantPreview',
        omschrijving: 'test 4 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '5', naam: 'test 5', uri: 'http://test.nl/klant(5)/klantPreview',
        omschrijving: 'test 5 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '6', naam: 'test 6', uri: 'http://test.nl/klant(6)/klantPreview',
        omschrijving: 'test 6 kdsh sihih askd faksaskdcakc ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '7', naam: 'test 7', uri: 'http://test.nl/klant(7)/klantPreview',
        omschrijving: 'test 7 kdsh sihih askd faksaskdcakc ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '8', naam: 'test 8', uri: 'http://test.nl/klant(8)/klantPreview',
        omschrijving: 'test 8 kdsh sihih askd faksaskdcakc ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '9', naam: 'test 9', uri: 'http://test.nl/klant(9)/klantPreview',
        omschrijving: 'test 9 kdsh sihih askd faksaskdcakc ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '10', naam: 'test 10', uri: 'http://test.nl/klant(10)/klantPreview',
        omschrijving: 'test 10 kdsh sihih askd faksaskdcakc ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '11', naam: 'test 11', uri: 'http://test.nl/klant(11)/klantPreview',
        omschrijving: 'test 11 kdsh sihih askd faksaskdcakc ergerg eri guherg ujgfuy wetfuywteufywt euftwu'}
    ];

    const lijstItems1: Klant[] = [
      {id: '10', naam: 'Bacon ipsum dolor',
        omschrijving: `Bacon ipsum dolor amet bresaola turkey buffalo tongue cupim.
        Short ribs meatloaf bresaola landjaeger, picanha ham hock turkey short loin.`,
        extras: [{ key: 'key 1', value: 'test value 1' }, { key: 'key 2', value: 'test value 2' }]
      },
      {id: '12', naam: 'Pork chop biltong drumstick ',
        omschrijving: 'test 2 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '13', naam: 'Ham pork belly fatback',
        omschrijving: 'test 3 kdsh sihih ergerg eri guherg ujgfuy wetfuywteufywt euftwu'},
      {id: '14', naam: 'Filet mignon',
        omschrijving: 'test 1 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '15', naam: 'Beef sirloin short ',
        omschrijving: 'test 2 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'}
    ];

    const lijstItems2: Klant[] = [
      {id: '24', naam: 'Filet mignon',
      omschrijving: 'test 1 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '25', naam: 'Beef sirloin short ',
        omschrijving: 'test 2 skjdhfkj sdak fhaskjdf asdfkjasd fjkdsf asgf asd ujgfuy wetfuywteufywt euftwu'},
      {id: '26', naam: 'Bacon ipsum dolor',
        omschrijving: `Bacon ipsum dolor amet bresaola turkey buffalo tongue cupim.
        Short ribs meatloaf bresaola landjaeger, picanha ham hock turkey short loin.`}
    ];

    if (request.url.endsWith('/lijst/1') && request.method === 'GET') {
      return of(new HttpResponse({ status: 200, body: lijstItems1 }));
    }

    if (request.url.endsWith('/lijst/2') && request.method === 'GET') {
      return of(new HttpResponse({ status: 200, body: lijstItems2 }));
    }

    if (!request.url.endsWith('undefined')) {
      if (request.url.includes('/lijst/') && request.method === 'GET') {
        return of(new HttpResponse({ status: 200, body: lijstItems }));
      }
    }


    const onderdelen: Onderdeel[] = [
      {id: '24', titel: 'Filet mignon', uri: '', acties: '', soort: ''},
      {id: '25', titel: 'Beef sirloin short '},
      {id: '26', titel: 'Bacon ipsum dolor' }
    ];

    if (request.url.endsWith('onderdeel')) {
      return of(new HttpResponse({ status: 200, body: onderdelen }));
    }

    const regels: any[] = [
      {id: '1', titel: 'Filet mignon'},
      {id: '2', titel: 'Beef sirloin short'},
      {id: '2', titel: 'Bacon ipsum dolor'}
    ];

    if (request.url.endsWith('regels')) {
      return of(new HttpResponse({ status: 200, body: regels }));
    }

    const klantPreview: Klant = {
      id: 'klant1',
      naam: 'Test Klant preview',
      omschrijving: 'test omschrijving klantpreview',
      geboortedatum: new Date(),
      status: 0,
      uri: '',
      extras: [
        { key: 'Test key 1', value: 'test value 1' },
        { key: 'Test key 2', value: 'test value 2' }
      ]
    };

    if (request.url.endsWith('klantPreview')) {
      return of(new HttpResponse({ status: 200, body: klantPreview }));
    }

    return next.handle(request);
  }
}

export let fakeBackendProvider = {
  // use fake backend in place of Http service for backend-less development
  provide: HTTP_INTERCEPTORS,
  useClass: FakeService,
  multi: true
};

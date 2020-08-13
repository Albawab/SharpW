import { Injectable } from '@angular/core';
import { HttpClient, HttpHeaders } from '@angular/common/http';
import { IConfig } from '../models/Iconfig';
import { Observable } from 'rxjs';
import { Bericht2 } from '../models/bericht';
import { catchError, map } from 'rxjs/operators';
// import { NavigatorItem } from 'projects/navigator/src/lib/models/navigatorItem';
import { BehaviorSubject } from 'rxjs';

@Injectable({
  providedIn: 'root'
})
export class AppService {
  // fakelijst: string;
  // private navigatorItem = new BehaviorSubject<Navigator>( new Navigator() );
  // currentNavigatorItem = this.navigatorItem.asObservable();

  configUrl = '../assets/config/config.json';
  config: IConfig;
  showEditBerichtUserInterface = new BehaviorSubject<Boolean>(false);
  showEditklantcontactUserInterface = new BehaviorSubject<Boolean>(false);

  constructor(private http: HttpClient) { }

  init() {
    return new Promise((resolve, reject) => {
          console.log('initialize config App');

          setTimeout(() => {
             this.http.get<IConfig>(this.configUrl)
            .toPromise()
            .then(res => {
              this.config = res;
              console.log('Config res: ', res );
              console.log('Config: ', this.config );
              return res;
            });

            resolve();
          }, 3000);
        });
  }

  getBerichtById(id): Observable<any> {
    const url = 'http://localhost:49800/odata/Berichten' + '(' + id + ')' ;
    return this.http.get<any>(url);
  }

  postBericht(bericht: Bericht2): Observable<any> {
    const url = 'http://localhost:49800/odata/Berichten';
    // const berichtToSend = JSON.stringify(bericht);
    // const headers = new HttpHeaders().set('content-type', 'application/json');

    const headers = new HttpHeaders({
        'Content-Type': 'application/json',
        'Access-Control-Allow-Origin': '*',
        'Access-Control-Allow-Methods': 'GET, POST, OPTIONS, PUT, PATCH, DELETE',
        'Access-Control-Allow-Headers':
        // tslint:disable-next-line:max-line-length
        'Access-Control-Allow-Headers, Origin,Accept, X-Requested-With, Content-Type, Access-Control-Request-Method, Access-Control-Request-Headers'
      });

    return this.http.post<Bericht2>(url, bericht, {headers});
  }

  // getKlantcontactById(id): Observable<any> {
  //   const url = 'http://localhost:49800/odata/Klantcontact' + '(' + id + ')' ;
  //   return this.http.get<any>(url);
  // }

  postKlantcontact(klantcontact: any): Observable<any> {
    const url = 'http://localhost:49800/odata/Klantcontact';

    return this.http.post<any>(url, klantcontact);
  }

  // getConfig(): any {
  //   return this.config;
  // }


  // OnChangeNavigator(navigator: any) {
  //   this.fakelijst = navigator.titel;

    // ik wil naar de viewlijstcvomponent en daar weil ik de items laten zien van deze navigator item

    // hoe vertel ik dat component welke uri hij moet aanroepen om de juiste gegevens terug te krijgen?

    // common.hene.nl/mappen/id?  (dan weet je niet uin welke db je zit? of zit dat in een common db?)
    // berichten.hene.nl/mappen/id

  // }

}

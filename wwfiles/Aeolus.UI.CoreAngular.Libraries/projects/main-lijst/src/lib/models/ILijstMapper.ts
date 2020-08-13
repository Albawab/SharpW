
import { Injectable } from '@angular/core';
import { LijstItem } from './lijstItem';
import { Observable } from 'rxjs';

@Injectable()
export abstract class ILijstMapper {
  abstract GetItemsFromUrl(url: string): Observable<LijstItem[]>;
}

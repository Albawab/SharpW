import { Injectable } from '@angular/core';
import { BehaviorSubject, Observable } from 'rxjs';
import { Header } from './models/header';

@Injectable({
  providedIn: 'root'
})
export class HeaderService {
  // private header = new BehaviorSubject<Header>( new Header() );
  // currentHeader = this.header.asObservable();
  private isSignOut = new BehaviorSubject<Boolean>(false);
  currentIsSignOut = this.isSignOut.asObservable();


  constructor() { }

  // changeHeader(header: Header) {
  //   this.header.next(header);
  // }

  signOut(signOut: Boolean) {
    this.isSignOut.next(signOut);
  }

}

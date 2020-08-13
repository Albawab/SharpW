import { Component, OnInit, Input, Output, EventEmitter, ViewChild } from '@angular/core';
import { DialogComponent } from '@syncfusion/ej2-ng-popups';
import { EmitType } from '@syncfusion/ej2-base';
import { AutoCompleteComponent } from '@syncfusion/ej2-ng-dropdowns';
import { Router } from '@angular/router';
import { HeaderService } from './header.service';

// declare let alertify: any;

@Component({
  selector: 'hene-header',
  templateUrl: './header.component.html',
  styleUrls: ['./header.component.scss']
})
export class HeaderComponent implements OnInit {
  @ViewChild('confirmDialogHeader') confirmDialog: DialogComponent;
  @ViewChild('zoek') public AutoCompleteObj: AutoCompleteComponent;
  public value = '';
  // public waterMark = 'Zoeken';
  public waterMark = '';
  public height = '250px';
  public sorting = 'Ascending';

  @Input() titel: string;
  @Input() icon: string;
  @Output() openModulesMenu: EventEmitter<any> = new EventEmitter();
  // @Output() signOut: EventEmitter<any> = new EventEmitter();
  public confirmHeader = 'Aeolus';
  public dialogContent = 'Weet u zeker dat u wilt uitloggen?';
  public position: object = { X: 'center', Y: 'center' };
  public confirmCloseIcon: Boolean = true;
  public confirmWidth = '400px';
  public isModal: Boolean = true;
  public hidden = false;

  /*
  'Fade' | 'FadeZoom' | 'FlipLeftDown' | 'FlipLeftUp' | 'FlipRightDown' | 'FlipRightUp' | 'FlipXDown' | 'FlipXUp' |
   'FlipYLeft' | 'FlipYRight' | 'SlideBottom' | 'SlideLeft' | 'SlideRight' | 'SlideTop' | 'Zoom'| 'None'
  */
 public animationSettings: Object = { effect: 'None', duration: 500 };
 public target = '.main-container';

 public confirmDlgButtons: Object[] = [
   { click: this.logout.bind(this),
     buttonModel: { content: 'Ja', isPrimary: true }
   },
   { click: this.closeDialog.bind(this),
     buttonModel: { content: 'Nee' } }
   ];

  constructor(private _headerService: HeaderService, private router: Router) { }

  ngOnInit() {
  }

  onChange(args: any): void {
    const valueEle: HTMLInputElement = document.getElementsByClassName('e-input')[0] as HTMLInputElement;
    // make empty the input value when typed characters is 'null' in input element
    if (this.AutoCompleteObj.value === 'null' || this.AutoCompleteObj.value === null || this.AutoCompleteObj.value === '') {
        valueEle.value = '';
    } else {
      // this.appService.changeZoekTerm(valueEle.value);
      this.value = valueEle.value;
      this.router.navigateByUrl('/home/' + this.value);
    }
  }

  openMenu() {
    this.openModulesMenu.emit('closeMenu');
  }

  confirmLogout: EmitType<object> = () => {
    this.confirmDialog.show();
  }

  logout() {
    this._headerService.signOut(true);
    console.log('logged uit');
    this.closeDialog();

  }

  closeDialog() {
    this.confirmDialog.hide();
  }

}

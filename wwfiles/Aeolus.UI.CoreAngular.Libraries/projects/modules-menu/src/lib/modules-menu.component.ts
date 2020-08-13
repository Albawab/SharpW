import { Component, OnInit, Input, ViewChild, Output, EventEmitter } from '@angular/core';
import { EmitType } from '@syncfusion/ej2-base';
import { DialogComponent } from '@syncfusion/ej2-ng-popups';
import { ModuleItem } from './models/moduleItem';
import { ModulesMenuService } from './modules-menu.service';

// declare let alertify;

@Component({
  selector: 'hene-modules-menu',
  templateUrl: './modules-menu.component.html',
  styleUrls: ['./modules-menu.component.scss']
})
export class ModulesMenuComponent implements OnInit {
  @ViewChild('confirmDialog') confirmDialog: DialogComponent;
  @Input() url: string;
  @Input() usernaam: string;
  @Output() signOut: EventEmitter<any> = new EventEmitter();
  public confirmHeader = 'Aeolus';
  public dialogContent = 'Weet u zeker dat u wilt uitloggen?';
  public position: object = { X: 'center', Y: 'center' };
  public confirmCloseIcon: Boolean = true;
  public confirmWidth = '400px';
  public isModal: Boolean = true;
  public hidden = false;

  public modules: ModuleItem[];
  public isOpen = false;

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

  constructor(private modulesService: ModulesMenuService) { }

  ngOnInit() {
    this.modulesService.getMenuItems(this.url).subscribe((result) => {
      this.modules = result;
      }, error => {
          console.log(error);
      });
  }

  toggleMenu() {
    this.isOpen = !this.isOpen;
  }

  confirmLogout: EmitType<object> = () => {
    this.confirmDialog.show();
  }

  logout() {
    this.signOut.emit('signOut');
    this.closeDialog();
  }

  closeDialog() {
    this.confirmDialog.hide();
  }
}

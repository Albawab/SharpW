import { Component, OnInit, ViewChild } from '@angular/core';
import { trigger, state, style, animate, transition } from '@angular/animations';
import { DialogComponent } from '@syncfusion/ej2-ng-popups';
import { EmitType } from '@syncfusion/ej2-base';

@Component({
  selector: 'hene-events',
  templateUrl: './events.component.html',
  styleUrls: ['./events.component.scss'],
  animations: [
    // the fade-in/fade-out animation.
    trigger('fadeAnimation', [

      // the "in" style determines the "resting" state of the element when it is visible.
      state('in', style({opacity: 1})),

      // fade in when created. this could also be written as transition('void => *')
      transition(':enter', [
        style({opacity: 0}),
        animate(1000 )
      ]),

      // fade out when destroyed. this could also be written as transition('void => *')
      transition(':leave',
        animate(1000, style({opacity: 0})))
    ])
  ]
})
export class EventsComponent implements OnInit {
  @ViewChild('confirmEventDialog') confirmEventDialog: DialogComponent;
  @ViewChild('toast') toast;
  public confirmHeader = 'Aeolus';
  public dialogContent = 'Weet u zeker dat u wilt deze item verwijderen';
  public position: object = { X: 'center', Y: 'center' };
  public confirmCloseIcon: Boolean = true;
  public confirmWidth = '400px';
  public isModal: Boolean = true;
  public hidden = false;
  public itemToDelete: any;

  public toastShowCloseBtn: Boolean = true;
  public toastShowProgresBar: Boolean = true;
  public positionToast = { X: 'Right', Y: 'Bottom' };
  public toastAnimation = { show: { effect: 'FadeIn', duration: 600, easing: 'linear' },
                            hide: { effect: 'FadeOut', duration: 600, easing: 'linear' } };

  /* effect
  'Fade' | 'FadeZoom' | 'FlipLeftDown' | 'FlipLeftUp' | 'FlipRightDown' | 'FlipRightUp' | 'FlipXDown' | 'FlipXUp' |
   'FlipYLeft' | 'FlipYRight' | 'SlideBottom' | 'SlideLeft' | 'SlideRight' | 'SlideTop' | 'Zoom'| 'None'
   duration: 400
  */
  public animationSettings: Object = { effect: 'None', duration: 500 };
  // public target = '.he-content-container';
  public target = 'body';

  public confirmDlgButtons: Object[] = [
    { click: this.banClick.bind(this),
      buttonModel: { content: 'Ja', isPrimary: true }
    },
    { click: this.closeDialog.bind(this),
      buttonModel: { content: 'Nee' } }
    ];

  public events: any[] = [
    { id: 1, titel: 'Test event 1', omschrijving: 'Begin om 11:45' },
    { id: 2, titel: 'Test event 2', omschrijving: 'Begin om 12:45' },
    { id: 3, titel: 'Test event 3', omschrijving: 'Begin om 13:45' },
    { id: 4, titel: 'Test event 4', omschrijving: 'Begin om 14:45' },
    { id: 5, titel: 'Test event 5', omschrijving: 'Begin om 16:45' }
  ];

  constructor() { }

  ngOnInit() {
  }

  confirmBtnClick: EmitType<object> = (data) => {
    this.itemToDelete = data;
    this.confirmEventDialog.show();
  }

  banClick(data) {
    if (this.itemToDelete) {
      const index = this.events.indexOf(this.itemToDelete);
      this.events.splice(index, 1);
      this.toast.cssClass = 'e-toast-success';
      this.toast.icon = 'fal fa-check-circle';
      this.toast.title = this.itemToDelete.titel + ' is verwerkt.';
      this.toast.content = 'Test content';
      this.toast.show();
    }

    this.confirmEventDialog.hide();
  }

  checkClick(data) {
    console.log('Goed', data);
  }

  closeDialog() {
    this.confirmEventDialog.hide();
  }
}

import { Component, OnInit, Input, ViewChild, AfterViewInit, OnChanges, SimpleChanges, ElementRef } from '@angular/core';
import { FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';
import { ActivatedRoute } from '@angular/router';
import { NavigatorMapService } from 'navigatorMap';
import { DialogComponent } from '@syncfusion/ej2-ng-popups';
import { EmitType } from '@syncfusion/ej2-base';
import { AppService } from '../shared/services/app.service';
import { NavigatorMapMapper } from '../shared/mappers/NavigatorMapMapper';

// declare let TXTextControlWeb: any;
// declare let TXTextControl: any;

@Component({
  selector: 'hene-edit-bericht',
  templateUrl: './edit-bericht.component.html',
  styleUrls: ['./edit-bericht.component.scss']
})
export class EditBerichtComponent implements OnInit {
  @ViewChild('Dialog') public Dialog: DialogComponent;
  public berichtForm: FormGroup;
  public header = 'Bericht verwerken';
  public showCloseIcon: Boolean = true;
  public width = '95%';
  public height = '100%';
  public isModal: Boolean = true;
  public animationSettings: Object = { effect: 'None' };
  public target = '.main-container';
  public bericht: any;

  // AS - Voor validations
  validationMessages = {
    'volgnr': {
      'required': 'Volgnummer is verplicht',
      'minlength': 'Volgnummer moet groter dan 3 karakters zijn',
      'maxlength': 'Volgnummer moet minder dan 10 karakters zijn'
    },
    'kenmerk': {
      'required': 'Kenmerk is verplicht',
      'kenmerkCustomValidation': 'Kenmerk moet "Test54" zijn.'
    }
  };

  formErrors = {
    'volgnr': '',
    'kenmerk': ''
  };

  constructor(private navigatorMapService: NavigatorMapService,
              private appService: AppService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.navigatorMapService.itemChanged.subscribe((currentItem) => {
      this.appService.getBerichtById(currentItem.id).subscribe((bericht) => {
        this.bericht = bericht.value[0];

        this.berichtForm = this.formBuilder.group({
          volgnr: [this.bericht.Volgnr, [Validators.required, Validators.minLength(3), Validators.maxLength(10)]],
          // kenmerk: [this.bericht.Kenmerk, [Validators.required, kenmerkCustomValidation]],
          kenmerk: [this.bericht.Kenmerk, Validators.required],
          idGemeente: this.bericht.IdGemeente,
          datumAangemaakt: this.bericht.DatumAangemaakt,
          uitgaand: this.bericht.Uitgaand,
          berichtStatus: this.bericht.CBerichtStatus,
          doenVoor: this.bericht.DoenVoor,
          DatumVerzonden: this.bericht.DatumVerzonden,
          referentie: this.bericht.Referentie,
          crossReferentie: this.bericht.CrossReferentie
        });

        this.berichtForm.valueChanges.subscribe( (data) => {
          this.logValidationErrors();
        });
      });
    });

    this.appService.showEditBerichtUserInterface.subscribe((showUserInterface) => {
      if (this.Dialog) {
        if (showUserInterface) {
          this.Dialog.show();
        } else {
          this.Dialog.hide();
        }
      }
    });

  }

  logValidationErrors(group: FormGroup = this.berichtForm): void {
    Object.keys(group.controls).forEach((key: string) => {
      const abstractControl = group.get(key);
      if (abstractControl instanceof FormGroup) {
        this.logValidationErrors(abstractControl);
      } else {
        this.formErrors[key] = '';
        // console.log('Key = ' + key + ' -  Value = ' + abstractControl.value);
        if (abstractControl && !abstractControl.valid &&
            (abstractControl.touched || abstractControl.dirty)) {

          const messages = this.validationMessages[key];

          for (const errorKey in abstractControl.errors) {
            if (errorKey) {
              this.formErrors[key] += messages[errorKey] + ' ';
            }
          }
        }
      }
    });
  }

  onSubmit(): void {
    // console.log(this.berichtForm.value);
    if (this.berichtForm.valid) {
      this.send(this.berichtForm.value);
    } else {
      console.log(this.berichtForm.value);
    }
  }

  private send(bericht) {
    this.appService.postBericht(bericht).subscribe((data) => {
      console.log(data);
      this.Dialog.hide();
    });
  }

  // public isFieldValid(field: string) {
  //   return !this.berichtForm.get(field).valid
  //   && (this.berichtForm.get(field).dirty || this.berichtForm.get(field).touched);
  // }

}

function kenmerkCustomValidation(control: AbstractControl): {[key: string]: any} | null {
  const kenmerk = control.value;
  if (kenmerk.toLowerCase() === 'test54') {
    return null;
  } else {
    return {'kenmerkCustomValidation': true};
  }
}

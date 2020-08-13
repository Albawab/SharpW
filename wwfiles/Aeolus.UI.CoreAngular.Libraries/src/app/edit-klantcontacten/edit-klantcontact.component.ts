import { Component, OnInit, ViewChild } from '@angular/core';
import { FormBuilder, FormGroup, Validators, AbstractControl } from '@angular/forms';
// import { ActivatedRoute } from '@angular/router';
import { NavigatorMapService } from 'navigatorMap';
import { DialogComponent } from '@syncfusion/ej2-ng-popups';
import { AppService } from '../shared/services/app.service';
import { Klantcontact } from '../shared/models/klantcontact';
import { EmitType } from '@syncfusion/ej2-base';
import { UploaderComponent, RemovingEventArgs } from '@syncfusion/ej2-ng-inputs';
// import { NavigatorMapMapper } from '../shared/mappers/NavigatorMapMapper';

@Component({
  selector: 'hene-edit-klantcontact',
  templateUrl: './edit-klantcontact.component.html',
  styleUrls: ['./edit-klantcontact.component.scss']
})
export class EditKlantcontactComponent implements OnInit {
  @ViewChild('dialogKlantContact') public dialog: DialogComponent;
  @ViewChild('defaultupload') public uploadObj: UploaderComponent;
  public path: Object = {
    saveUrl: 'https://aspnetmvc.syncfusion.com/services/api/uploadbox/Save',
    removeUrl: 'https://aspnetmvc.syncfusion.com/services/api/uploadbox/Remove'
};
  public klantcontactForm: FormGroup;
  public header = 'Klantcontact verwerken';
  public showCloseIcon: Boolean = true;
  public width = '95%';
  public height = '100%';
  public isModal: Boolean = true;
  public animationSettings: Object = { effect: 'None' };
  public target = '.main-container';
  public klantcontact: Klantcontact;
  public subSoorten = [
    { Id: 47, Naam: 'Contact opnemen'},
    { Id: 48, Naam: 'Informeren'},
    { Id: 49, Naam: 'Onderzoeker'},
    { Id: 50, Naam: 'Overige'}
  ];

  public statussen = [
    { Id: 0, Naam: 'Niet gedefinieerd'},
    { Id: 1, Naam: 'Niet gestart'},
    { Id: 2, Naam: 'Wordt uitgevoerd'},
    { Id: 4, Naam: 'Wacht op iemand anders'},
    { Id: 5, Naam: 'Uitgesteld' },
    { Id: 20, Naam: 'Niet van toepassing' },
    { Id: 99, Naam: 'Voltooid' }
  ];

  public prioriteiten = [
    { Id: 0, Naam: 'Laag'},
    { Id: 1, Naam: 'Normaal'},
    { Id: 2, Naam: 'Hoog'},
  ];

  public uivoerders = [
    { Id: '00000000-0000-0000-0000-000000000001', Naam: 'Test uivoerder 1'},
    { Id: '00000000-0000-0000-0000-000000000002', Naam: 'Test uivoerder 2'},
    { Id: '00000000-0000-0000-0000-000000000003', Naam: 'Test uivoerder 3'},
  ];

  public fields: Object = { text: 'Naam', value: 'Id' };

  public dropElement: HTMLElement = document.getElementsByClassName('control-fluid')[0] as HTMLElement;

  // AS - Voor validations
  validationMessages = {
    'subsoort': {
      'required': 'subsoort is verplicht'
    },
    'status': {
      'required': 'status is verplicht'
    },
    'onderwerp': {
      'required': 'Onderwerp is verplict'
    },
    'begindatum': {
      'required': 'Begindatum is verplict'
    }
  };

  formErrors = {
    'subsoort': '',
    'status': '',
    'onderwerp': '',
    'begindatum': ''
  };

  constructor(private navigatorMapService: NavigatorMapService,
              private appService: AppService, private formBuilder: FormBuilder) { }

  ngOnInit(): void {
    this.klantcontact = {
      Id: '00000000-0000-0000-0000-000000000000',
      Soort: 0,
      SoortNaam: 'Taak',
      SubSoortId: 47,
      SubSoortNaam: 'Contact opnemen',
      Status: 2,
      Onderwerp: 'Test onderwerp',
      MeenemenInVerslag: true,
      Begindatum: null
    };

    this.klantcontactForm = this.formBuilder.group({
      subsoort: [this.klantcontact.SubSoortId || 50, Validators.required],
      status: [this.klantcontact.Status || 0, Validators.required],
      onderwerp: [this.klantcontact.Onderwerp || '', Validators.required],
      locatie: this.klantcontact.Locatie || '',
      meenemenInVerslag: this.klantcontact.MeenemenInVerslag || false,
      prioriteit: this.klantcontact.Prioriteit || 1,
      begindatum: [this.klantcontact.Begindatum || new Date(), Validators.required],
      doenVoor: this.klantcontact.DoenVoor,
      einddatum: this.klantcontact.Einddatum,
      uitvoering: this.klantcontact.UitvoeringDoor,
      gemeldDoor: this.klantcontact.GemeldDoor,
      privacySoort: this.klantcontact.PrivacySoort || '1',
      inhoud: this.klantcontact.Inhoud || ''
    });

    this.klantcontactForm.valueChanges.subscribe( (data) => {
      this.logValidationErrors();
    });

    this.appService.showEditklantcontactUserInterface.subscribe((showUserInterface) => {
      if (this.dialog) {
        if (showUserInterface) {
          this.dialog.show();

        } else {
          this.dialog.hide();
        }
      }
    });
  }

  logValidationErrors(group: FormGroup = this.klantcontactForm): void {
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
    if (this.klantcontactForm.valid) {
      this.send(this.klantcontactForm.value);
    } else {
      console.log(this.klantcontactForm.value);
    }
  }

  public changeHandler: EmitType<Object> = () => {
    this.uploadObj.autoUpload = true;
    this.uploadObj.clearAll();
  }

  public onFileRemove(args: RemovingEventArgs): void {
      args.postRawFile = false;
  }

  private send(klantcontact) {
    this.appService.postKlantcontact(klantcontact).subscribe((data) => {
      console.log(data);
      this.dialog.hide();
    });
  }

  public isFieldValid(field: string) {
    return !this.klantcontactForm.get(field).valid && (this.klantcontactForm.get(field).dirty || this.klantcontactForm.get(field).touched);
  }
}

function kenmerkCustomValidation(control: AbstractControl): {[key: string]: any} | null {
  const kenmerk = control.value;
  if (kenmerk.toLowerCase() === 'test54') {
    return null;
  } else {
    return {'kenmerkCustomValidation': true};
  }
}

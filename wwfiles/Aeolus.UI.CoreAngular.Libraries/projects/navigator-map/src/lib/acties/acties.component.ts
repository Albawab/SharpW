import { Component, OnInit, ViewEncapsulation, Input, OnChanges, SimpleChanges } from '@angular/core';
import { Button } from '@syncfusion/ej2-ng-buttons';
import { Toolbar, ItemModel } from '@syncfusion/ej2-navigations';
import { NavigatorMap } from '../models/navigatorMap';
import { LijstItem } from '../models/lijstItem';
import { NavigatorMapService } from '../navigator-map.service';

@Component({
  selector: 'hene-acties',
  templateUrl: './acties.component.html',
  styleUrls: ['./acties.component.scss'],
  encapsulation: ViewEncapsulation.None
})

export class ActiesComponent implements OnInit, OnChanges {
  @Input() navigatorMap: NavigatorMap;
  selectedtem: LijstItem;
  checkedItems: any = [];
  acties: ItemModel[] = [];
  actieDefinitie: any;

  constructor(private navigatorMapService: NavigatorMapService) {}

  ngOnInit() {
    this.navigatorMapService.geselecteerdItemsChanged.subscribe((selectedItems) => {
      console.log(selectedItems);
      if (selectedItems.data) {
        this.checkedItems = selectedItems.data;
      }
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.navigatorMap) {
      // console.log('NavigatorMap' + this.navigatorMap);
      if (this.navigatorMap.navigatorMapActies) {
        this.createActieItems(this.navigatorMap.navigatorMapActies);
      }
    }
  }

  createActieItems(navigatorMapActies) {
    // AS - Kijken als er is handig hier een mapping van een navigatorMapActies class (nu is any) naar een ItemModel class
    this.acties = navigatorMapActies;
  }

  onToolbarClick(args) {
    // check
    this.actieDefinitie = args.item;

    if (this.checkedItems) {

    let valid = false;

    switch (this.actieDefinitie.uitvoerenOpAantal) {
      case 'none':
        valid = this.checkedItems.length === 0;
          break;
      case 'enkel':
        valid = this.checkedItems.id || this.checkedItems.length === 1;
        break;
      case 'meerdere':
        valid = this.checkedItems.length > 1;
        break;
      case 'vastAantal':
        valid = this.checkedItems.length === this.actieDefinitie.selectedAantal;
        break;
    }

    // niet valid dan juiste melding naar de gebruiker
    if (!valid) {
      alert('Deze actie mag niet uigevoerd worden');
      return;
    }

    // zijn er items waarbij ik deze actie niet mag uitvoeren
    // wat ben ik? ben ik een enkele actie of is er UI vereist

    if (this.actieDefinitie.directUitvoeren) {

      for (const subactie of this.actieDefinitie.subActies) {
        let result = 'Failed';
        if (!subactie.voerUitOpAlleItems) {
          // voer de actie voor elk checked item apart uit
          if (this.checkedItems.length > 0) {
            for (const checkedItem of this.checkedItems) {
              result = this.navigatorMapService.processSubActie(subactie, checkedItem);
              if (result === 'Failed') {
                break;
              }
            }
          } else if (this.checkedItems.id) {
            result = this.navigatorMapService.processSubActie(subactie, this.checkedItems);
          }
        } else {
          // voor de actie uit voor alle items tegelijkertijd
          if (this.selectedtem) {
            result = this.navigatorMapService.processSubActie(subactie, this.checkedItems);
          }
        }

        if (result === 'Failed') {
          break;
        }
      }
    } else {
      // toon de wizard die ind e actie staat?
      // toon de juiste popup en geeft de subacties door,
      // zodat die na afloop uitgevoerd kunnen worden
    }
  } else {
    alert('Er zijn geen items geselecteerd om deze actie te uitvoeren');
  }
}

}

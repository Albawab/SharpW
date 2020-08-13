import { Component, OnInit, ViewChild, ViewEncapsulation, OnChanges, SimpleChanges, Input } from '@angular/core';
import { GridComponent, Grid } from '@syncfusion/ej2-ng-grids';
import { PreviewItem } from '../models/previewItem';
import { NavigatorMapService } from '../navigator-map.service';
import { LijstItem } from '../models/lijstItem';
import { NavigatorMap } from '../models/navigatorMap';
import { SoortItem } from '../models/enums';
import { BerichtPreviewComponent } from '../components/bericht-preview/bericht-preview.component';

@Component({
  selector: 'hene-preview-item',
  templateUrl: './preview-item.component.html',
  styleUrls: ['./preview-item.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class PreviewItemComponent implements OnInit, OnChanges {
  @Input() navigatorMap: NavigatorMap;
  public berichtPreview: BerichtPreviewComponent;
  public showActies: Boolean = false;
  public soortItem = SoortItem;
  public itemPreview: PreviewItem;
  public soortInhoud: string;
  // TODO: AS -dit url moet ik ergens krijgen, waarschijnlijk vanaf de ListItem.
  public url: string; // = 'http://localhost:49800/odata/Berichten';

  constructor(private navigatorMapService: NavigatorMapService) { }

  ngOnInit() {
    this.navigatorMapService.itemChanged.subscribe((item) => {
      this.getItem(item);
    });
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.navigatorMap) {
      this.soortInhoud = this.navigatorMap.soortInhoud;
    }
  }

  showActiesMenu() {
    this.showActies = !this.showActies;
  }

  action(event, actie) {
    event.preventDefault();

    console.log('action', actie);

    // zijn er items waarbij ik deze actie niet mag uitvoeren
    // wat ben ik? ben ik een enkele actie of is er UI vereist

    if (actie.directUitvoeren) {

      let result = 'Failed';
      for (const subactie of actie.subActies) {
            result = this.navigatorMapService.processSubActie(subactie, actie);
      }

      if (result === 'Failed') {
        console.log('Deze actie komt niet uigevoerd worden');
        this.berichtPreview.getErrorMessage('Deze actie komt niet uigevoerd worden');
      }
    } else {
      // toon de wizard die ind e actie staat?
      // toon de juiste popup en geeft de subacties door,
      // zodat die na afloop uitgevoerd kunnen worden
    }

    console.log('Event', event);
    console.log('Item', actie);
    this.showActiesMenu();
  }

  private getItem(item: LijstItem) {
    if (item && this.soortInhoud ) {
      if (item.uri) {
        this.url = item.uri;
      } else {
        this.url = 'http://localhost:49800/odata/Berichten' + '(' + item.id + ')' ;
      }
      this.navigatorMapService.getPreviewItem(this.url, this.soortInhoud).subscribe((data) => {
        this.itemPreview = data;
      }, error => {
        this.berichtPreview.getErrorMessage(error);
      });
    }
  }

}

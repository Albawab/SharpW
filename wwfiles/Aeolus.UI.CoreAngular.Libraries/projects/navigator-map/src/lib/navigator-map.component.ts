import { Component, OnInit, ViewChild } from '@angular/core';
import { ActivatedRoute } from '@angular/router';
import { PreviewItemComponent } from './preview-item/preview-item.component';
import { NavigatorMap } from './models/navigatorMap';
import { NavigatorMapService } from './navigator-map.service';
import { ActiesComponent } from './acties/acties.component';
import { LijstItem } from './models/lijstItem';

@Component({
  selector: 'hene-navigator-map',
  templateUrl: './navigator-map.component.html',
  styleUrls: ['./navigator-map.component.scss']
})
export class NavigatorMapComponent implements OnInit {
  @ViewChild('previewItem') previewItem: PreviewItemComponent;
  @ViewChild('actiesMenu') actiesMenu: ActiesComponent;
  public loading = false;
  public navigatorMap: NavigatorMap;
  // public id: string;
  public zoekterm: string;
  public titel: string;
  // AS - dit moet vanaf get data
  // public urlLijstItems = 'http://localhost:51750/swagger/api/v1/lijst/';

  constructor(private route: ActivatedRoute, private navigatorMapService: NavigatorMapService ) {}

  ngOnInit() {
    this.navigatorMapService.navigatorItemChanged.subscribe((data) => {
      this.loading = true;
      this.navigatorMapService.getNavigatorMap(data.uri).subscribe((res) => {
        this.navigatorMap = res;
        this.loading = false;
      });
    });

    // this.route.params.subscribe(params => {
    //   this.id = params['id'];
    //   this.zoekterm = params['zoekterm'];
    //     if (this.zoekterm) {
    //       this.titel = 'Gezocht op: ' + this.zoekterm;
    //     }
    //     if (this.id) {
    //       this.titel = params['titel'];
    //     }
    // });
  }

  getNotification(data) {
    this.actiesMenu.selectedtem = data;
  }

  // getCheckedItems(data) {
  //   console.log(data);
  //   this.actiesMenu.checkedItems = data;
  // }
}

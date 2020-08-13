import { Component, OnInit, ViewChild, Input, OnChanges, SimpleChanges } from '@angular/core';
import { DataManager, ReturnOption, Query, ODataV4Adaptor } from '@syncfusion/ej2-data';
import { PreviewItem } from '../../models/previewItem';
import { ToastComponent } from '@syncfusion/ej2-ng-notifications';
import { AccordionComponent, ClickEventArgs } from '@syncfusion/ej2-ng-navigations';
import { ToolbarItems, PageSettingsModel, GridComponent, FilterSettingsModel } from '@syncfusion/ej2-ng-grids';
import { NavigatorMapService } from '../../navigator-map.service';

const SERVICE_URI = 'https://services.odata.org/V4/Northwind/Northwind.svc/Invoices';

@Component({
  selector: 'hene-bericht-preview',
  templateUrl: './bericht-preview.component.html',
  styleUrls: ['./bericht-preview.component.scss']
})
export class BerichtPreviewComponent implements OnInit, OnChanges {
  @Input() itemPreview: PreviewItem;
  @ViewChild('toast') toast: ToastComponent;
  @ViewChild('gridRegels') gridRegels: GridComponent;
  @ViewChild('accordion') accordion: AccordionComponent ;
  public toolbarOptions: ToolbarItems[];
  public filterOption: FilterSettingsModel = { type: 'Excel'};
  public options: PageSettingsModel;
  public positionToast = { X: 'Right', Y: 'Bottom' };
  public regelsData: Object[] = [];

  constructor(private navigatorMapService: NavigatorMapService) { }

  ngOnInit() {
    this.options = { pageSize: 15 };
    this.toolbarOptions = ['ExcelExport'];
  }

  ngOnChanges(changes: SimpleChanges): void {
    if (this.accordion) {
      for (let i = 0; i < this.accordion.items.length; i++) {
        this.accordion.expandItem(false, i);
      }
    }
  }

  loadRegelsGrid() {
    this.regelsData = [];
    this.navigatorMapService.getItemsFromUrl(SERVICE_URI).subscribe((res) => {
      console.log(res);
      this.regelsData = res.value;
    });

    // new DataManager({ url: SERVICE_URI, adaptor: new ODataV4Adaptor})
    //   .executeQuery(new Query().range(0, 500)).then((e: ReturnOption) => {
    //     const result: any = e.result;
    //     this.regelsData = result;
    //   });
  }

  expandedAccordion(args) {
    console.log(args);
    this.loadRegelsGrid();
  }

  onActionFailure(e): void {
    this.getErrorMessage(e);
  }

  toolbarClick(args: ClickEventArgs): void {
    if (args.item.id === 'GridRegels_excelexport') { // 'Grid_excelexport' -> Grid component id + _ + toolbar item name
        this.gridRegels.excelExport();
    }
  }

  getErrorMessage(err) {
    this.toast.cssClass = 'e-toast-danger';
    // this.toast.icon = 'fal fa-check-circle';
    this.toast.title = 'Fout met data ophalen';
    if (err.message) {
      this.toast.content = 'Fout: ' + err.message;
    } else if (err.error) {
      this.toast.content = 'Fout: ' + err.error;
    } else {
      this.toast.content = 'Fout: ' + err;
    }
    this.toast.show();
  }

}

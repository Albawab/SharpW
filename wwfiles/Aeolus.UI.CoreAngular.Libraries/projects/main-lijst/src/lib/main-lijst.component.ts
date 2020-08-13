import { Component, OnInit, ViewEncapsulation, Input, ViewChild, Output, EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { ItemModel, MenuEventArgs } from '@syncfusion/ej2-ng-splitbuttons';
import { LijstItem } from './models/lijstItem';
import { ContextMenuComponent, MenuItemModel } from '@syncfusion/ej2-ng-navigations';
import { ListViewComponent, SortOrder } from '@syncfusion/ej2-ng-lists';
import { Button } from '@syncfusion/ej2-ng-buttons';
import { DataManager, Query, ODataV4Adaptor, ReturnOption } from '@syncfusion/ej2-data';
import { MainLijstService } from './main-lijst.service';

// const SERVICE_URI =  'http://localhost:5600/odata/Berichten/';

@Component({
  selector: 'hene-main-lijst',
  templateUrl: './main-lijst.component.html',
  styleUrls: ['./main-lijst.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class MainLijstComponent implements OnInit, OnChanges {
  // @ViewChild('filterContextMenu') filterContextMenu: ContextMenuComponent;
  @ViewChild('listView') listView: ListViewComponent;
  @ViewChild('soortBtn') soortBtn: Button;
  @Input() headerTitel: string;
  @Input() id: string;
  @Input() url: string;
  @Output() notifyParent: EventEmitter<any> = new EventEmitter();
  // public fields: Object = { text: 'titel', id: 'id', groupBy: 'status' };
  public fields: Object = { text: 'titel', id: 'id' };
  public mainItem: LijstItem;
  public mainItems: LijstItem[] = [];

  public isSoortAsc: Boolean = false;
  public showCheckBox: Boolean = false;

  public filterItems: ItemModel[] = [
    {
        text: 'Dashboard',
        iconCss: 'fal fa-check'
    },
    {
        text: 'Notifications',
        iconCss: 'fal fa-check',
    },
    {
        text: 'User Settings',
        iconCss: 'fal fa-check',
    },
    {
        text: 'Log Out',
        iconCss: 'fal fa-check'
    }];

  // public filterMenuItems: MenuItemModel[] = [
  //     { text: 'All', iconCss: 'fal fa-check' }, { text: 'Status 1' },
  //     { text: 'Status 2' }, { separator: true }, { text: 'Sorteer op', items: [{ text: 'None' },
  //     { text: 'Ascending', iconCss: 'fal fa-check' }, { text: 'Descending' }] }
  // ];

  constructor(private lijstService: MainLijstService) { }

  ngOnInit() {

    // this.createButtons();

    if (this.id) {
      this.getItems();
    }
  }

  ngOnChanges(changes: SimpleChanges) {
    if (this.id) {
      this.getItems();
    }
  }

  // itemBeforeEvent (args: MenuEventArgs) {
  //     args.element.getElementsByTagName('a')[0].setAttribute('target', '_blank');
  // }

  onRecordClick(data: LijstItem) {
      this.mainItem = data;
      this.sendNotification(data);
      console.log('Item click', data);
  }

  onRecordDoubleClick(data: LijstItem) {
      // this.router.navigate(['view', data.id, false]);
      console.log(data);
  }


  // selectAll(e: any) {
  //   if (e.checked) {
  //     this.listView.checkAllItems();
  //   } else {
  //     this.listView.uncheckAllItems();
  //   }
  // }

  showChecboxes(e: any) {
    if (e.checked) {
      this.showCheckBox = true;
    } else {
      this.showCheckBox = false;
    }
  }

  edit(data) {
    console.log('Edit', data);
  }

  delete(data) {
    console.log('Delete', data);
  }

  toogleSoort() {
    if (this.isSoortAsc) {
      this.listView.sortOrder = 'Ascending';
    } else {
      this.listView.sortOrder = 'Descending';
    }
    this.isSoortAsc = !this.isSoortAsc;
  }

  // createButtons() {
  //   this.soortBtn = new Button({
  //     cssClass: `e-flat`,
  //     iconCss: 'far fa-sort-alpha-up',
  //     isToggle: true
  //   });
  //   this.soortBtn.appendTo('#soortBtn');

  //   this.soortBtn.element.onclick = (): void => {
  //     this.soortBtn.refresh();
  //     if (this.soortBtn.element.classList.contains('e-active')) {
  //       this.soortBtn.iconCss = 'far fa-sort-alpha-up';
  //       this.toogleSoort();
  //     } else {
  //       this.soortBtn.iconCss = 'far fa-sort-alpha-down';
  //       this.toogleSoort();
  //     }
  //   };
  // }

  btnSoortClick() {
    if (this.isSoortAsc) {
      this.soortBtn.iconCss = 'e-icons sort-ascending';
      this.toogleSoort();
    } else {
      this.soortBtn.iconCss = 'e-icons sort-descending';
      this.toogleSoort();
    }
  }

  // getStatus1(chk: any) {
  //   this.mainItems = [];
  //   if (chk.checked) {
  //     new DataManager({ url: SERVICE_URI, adaptor: new ODataV4Adaptor })
  //     .executeQuery(new Query().addParams('$filter', 'Uitgaand eq 0'))
  //     .then((e: ReturnOption) => {
  //       this.mainItems = <Object[]>e.result;
  //       console.log(this.mainItems);

  //       this.mainItems = [];
  //       this.mainItems.forEach(bericht => {
  //         let status: number;
  //         if (bericht.Uitgaand === 0) {
  //           status = 1;
  //         } else {
  //           status = 0;
  //         }
  //         this.mainItems.push({id: bericht.Id, titel: bericht.Kenmerk, status: status });
  //       });

  //     }).catch((e) => true);
  //   } else {
  //     new DataManager({ url: SERVICE_URI, adaptor: new ODataV4Adaptor })
  //     .executeQuery(new Query().addParams('$filter', 'Uitgaand eq 1'))
  //     .then((e: ReturnOption) => {
  //       this.mainItems = <Object[]>e.result;
  //       console.log(this.mainItems);
  //       this.mainItems = [];
  //       this.mainItems.forEach(bericht => {
  //         let status: number;
  //         if (bericht.Uitgaand === 1) {
  //           status = 2;
  //         } else {
  //           status = 0;
  //         }
  //         this.mainItems.push({id: bericht.Id, titel: bericht.Kenmerk, status: status });
  //       });
  //     }).catch((e) => true);
  //   }
  // }

  // filterMenuSelect(args: MenuEventArgs): void {
  //   if (args.item) {
  //       if (args.item.text === 'Ascending' || args.item.text === 'Descending' ||  args.item.text === 'None') {
  //           this.listView.sortOrder = args.item.text as SortOrder;
  //           for (let i = 0; i < this.filterContextMenu.items[4].items.length; i++) {
  //               this.filterContextMenu.items[4].items[i].iconCss = '';
  //           }
  //           args.item.iconCss = 'fal fa-check';
  //       } else if (args.item.text !== 'Sorteer op') {
  //           this.clearFilterMenu();
  //           if (args.item.text === 'All') {
  //               this.listView.dataSource = this.mainItems;
  //           } else if (args.item.text === 'Status 1') {
  //               this.listView.dataSource = this.getFilteredDataSource(this.mainItems, 'status', '1');
  //           } else if (args.item.text === 'Status 2') {
  //               this.listView.dataSource = this.getFilteredDataSource(this.mainItems, 'status', '2');
  //           }
  //           args.item.iconCss = 'fal fa-check';
  //       }
  //   }
  // }

  // btnFilterClick(): void {
  //     const clientRect: ClientRect = document.getElementById('btnFilter').getBoundingClientRect();
  //     this.filterContextMenu.open(clientRect.top + 25, clientRect.left);
  // }

  // clearFilterMenu(): void {
  //   for (let i = 0; i < this.filterContextMenu.items.length; i++) {
  //       if (this.filterContextMenu.items[i].items.length === 0) {
  //           this.filterContextMenu.items[i].iconCss = '';
  //       }
  //   }
  // }

  getFilteredDataSource(dataSource: { [key: string]: Object }[], columnName: string, columnValue: string):
    { [key: string]: Object }[] {
        const folderData: { [key: string]: Object }[] = [];
        for (let i = 0; i < dataSource.length; i++) {
            const data: { [key: string]: Object } = dataSource[i];
            if (data[columnName] && data[columnName].toString() === columnValue) {
                folderData.push(data);
            }
        }
        return folderData;
  }

  private getItems() {
    this.lijstService.getLijstItems(this.url + this.id).subscribe((result) => {
      this.mainItems = result;
      }, error => {
          console.log(error);
      });

  }

  private sendNotification(data: any) {
    this.notifyParent.emit(data);
  }
}

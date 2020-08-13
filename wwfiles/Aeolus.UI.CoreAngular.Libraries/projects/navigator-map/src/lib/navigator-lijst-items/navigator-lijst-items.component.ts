import { Component, OnInit, ViewEncapsulation, Input, ViewChild, Output,
  EventEmitter, OnChanges, SimpleChanges } from '@angular/core';
import { ItemModel, MenuEventArgs } from '@syncfusion/ej2-ng-splitbuttons';
import { LijstItem } from '../models/lijstItem';
import { ContextMenuComponent, MenuItemModel, BeforeOpenCloseMenuEventArgs } from '@syncfusion/ej2-ng-navigations';
import { ListViewComponent, SortOrder, SelectedCollection } from '@syncfusion/ej2-ng-lists';
import { Button } from '@syncfusion/ej2-ng-buttons';
import { DataManager, Query, ODataV4Adaptor, ReturnOption } from '@syncfusion/ej2-data';
import { NavigatorMapService } from '../navigator-map.service';
import { NavigatorMap, TitelValue } from '../models/navigatorMap';

@Component({
  selector: 'hene-navigator-lijst-items',
  templateUrl: './navigator-lijst-items.component.html',
  styleUrls: ['./navigator-lijst-items.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class NavigatorLijstItemsComponent implements OnChanges {
  @ViewChild('filterContextMenu') filterContextMenu: ContextMenuComponent;
  @ViewChild('listView') listView: ListViewComponent;
  @ViewChild('soortBtn') soortBtn: Button;
  @ViewChild('toast') toast;
  @Input() navigatorMap: NavigatorMap;
  @Output() notifyParent: EventEmitter<any> = new EventEmitter();
  public loading: Boolean = false;
  public toastShowCloseBtn: Boolean = true;
  public toastShowProgresBar: Boolean = true;
  public positionToast = { X: 'Right', Y: 'Bottom' };
  // TODO - AS - GroupBy in de filter.
  // public fields: Object = { text: 'titel', id: 'id', groupBy: 'status' };
  public fields: Object = { text: 'titel', id: 'id' };
  public mainItem: LijstItem;
  public mainItems: any[] = [];

  public showCheckBox: Boolean = false;
  public showFilter: Boolean = false;

  public filterMenuItems: any[];

  constructor(private navigatorMapService: NavigatorMapService) {}

  ngOnChanges(changes: SimpleChanges) {
    if (this.navigatorMap) {
      this.createFilter();
      this.getItems();
    }
  }

  /** LijstItem functies */
  getCheckedItems() {
    const checkedItems = this.listView.getSelectedItems();
    console.log(checkedItems);
    if (checkedItems) {
      this.navigatorMapService.geselecteerdItemsChanged.next(checkedItems);
    }
  }

  onRecordClick(data: LijstItem) {
      this.mainItem = data;
      console.log(this.mainItem);
      this.sendNotification(data);
      this.getCheckedItems();
  }

  onRecordDoubleClick(data: LijstItem) {
      // this.router.navigate(['view', data.id, false]);
      console.log(data);
  }

  edit(data) {
    console.log('Edit', data);
  }

  delete(data) {
    console.log('Delete', data);
  }

  /** Filter functies */
  showFilterMenu() {
    this.showFilter = !this.showFilter;
  }

  /*
  selectAll(e: any) {
    if (e.checked) {
      this.listView.checkAllItem();
    } else {
      this.listView.unCheckAllItem();
    }
  }
  */

  showChecboxes(e: any) {
    if (e.checked) {
      this.showCheckBox = true;
    } else {
      this.showCheckBox = false;
    }
  }

  filterAction(event, item) {
    event.preventDefault();
    item.selected = !item.selected;

    let filter = '';
    let isFirst = true;
    // TODO: Als andere filter is geselecteerd dan 'Alles' deselecteren
    this.navigatorMap.filterOptions.forEach( ele => {
      if (item.value === ele.value) {
        ele.selected = item.selected;
      }
      if (ele.selected && ele.value) {
        if (isFirst) {
          filter += ele.value;
          isFirst = false;
        } else {
          filter += ' or ' + ele.value;
        }
      }
    });

    let order = '';
    this.navigatorMap.orderByOptions.forEach( ele => {
      if (item.value === ele.value && item.selected) {
        ele.selected = true;
        // item.selected = true; // -> AS - De filter wordt opnieuw gemaakt met de nieuw values
        order = item.value;
      } else {
        ele.selected = false;
      }
    });

    let group = '';
    this.navigatorMap.groupByOptions.forEach( ele => {
      if (item.value === ele.value) {
        ele.selected = true;
        // item.selected = true; // -> AS - De filter wordt opnieuw gemaakt met de nieuw values
        group = item.value;
      } else {
        ele.selected = false;
      }
      // this.makeNewSelected(this.navigatorMap.groupByOptions);
    });

    // refresh the filter with the new selected items
    this.createFilter();
    this.getItems(null, filter, order, group);
    this.showFilterMenu();
  }

  createFilter() {
    this.filterMenuItems = [];
    if (this.navigatorMap.filterOptions) {
      this.navigatorMap.filterOptions.forEach( (ele, index) => {
        let filterItem: any = {};
        filterItem = this.mapItem(filterItem, ele);
        this.filterMenuItems.push(filterItem);
      });
    }

    if (this.navigatorMap.orderByOptions) {

      const sorteerItem = { text: 'Sorteer op', items: [] };

      this.navigatorMap.orderByOptions.forEach(ele => {
        let orderItem: any = {};
        orderItem = this.mapItem(orderItem, ele);
        sorteerItem.items.push(orderItem);
      });

      this.filterMenuItems.push(sorteerItem);
    }

    if (this.navigatorMap.groupByOptions) {

      const groeperenItem = { text: 'Groeperen op', items: [] };

      this.navigatorMap.groupByOptions.forEach(ele => {
        let groepItem: any = {};
        groepItem = this.mapItem(groepItem, ele);
        groeperenItem.items.push(groepItem);
      });

      this.filterMenuItems.push(groeperenItem);
    }

    // console.log(this.filterMenuItems.length);
    // console.log(this.filterMenuItems);
  }

  mapItem(itemToMap, item) {
    itemToMap.text = item.titel;
    itemToMap.value = item.value;
    itemToMap.selected = item.selected;

    return itemToMap;
  }

  makeNewSelected(array: TitelValue[]) {
    array.forEach(ele => {
      if (!ele.selected) {
        ele.selected = false;
      }
    });
  }

  /** Start - AS - onderstande functies waren specifiek voor de Syncfusion ContextMenu */
  // filterMenuSelect(args: MenuEventArgs): void {
  //   if (args.item) {

  //     if (args.item.text.endsWith('asc') || args.item.text.endsWith('desc')) {

  //         this.getItems(null, null, args.item.text);

  //         // AS - filterContextMenu.items[4].items // items[4] heeft de items van de menu.
  //         for (let i = 0; i < this.filterContextMenu.items[4].items.length; i++) {
  //             this.filterContextMenu.items[4].items[i].iconCss = '';
  //         }
  //         args.item.iconCss = 'fal fa-check';
  //     } else if (args.item.text !== 'Sorteer op') {
  //         this.clearFilterMenu();
  //         if (args.item.text === 'All') {
  //             const filter = 'Volgnr' + ' eq ' + '13070';
  //             this.getItems(null, filter);
  //         } else if (args.item.text === 'Status 1') {
  //             const filter = 'Volgnr' + ' eq ' + '13075';
  //             this.getItems(null, filter);
  //         } else if (args.item.text === 'Status 2') {
  //             const filter = 'Volgnr' + ' eq ' + '13080';
  //             this.getItems(null, filter);
  //         }
  //         args.item.iconCss = 'fal fa-check';
  //     }
  //   }
  // }

  // btnFilterClick(): void {
  //   const clientRect: ClientRect = document.getElementById('btnFilter').getBoundingClientRect();
  //   // this.filterContextMenu.items = this.filterMenuItems;
  //   this.filterContextMenu.open(clientRect.top + 25, clientRect.left);
  // }

  // clearFilterMenu(): void {
  //   for (let i = 0; i < this.filterContextMenu.items.length; i++) {
  //     if (this.filterContextMenu.items[i].items.length === 0) {
  //       this.filterContextMenu.items[i].iconCss = '';
  //     }
  //   }
  // }

   // itemBeforeEvent (args: MenuEventArgs) {
   //     args.element.getElementsByTagName('a')[0].setAttribute('target', '_blank');
   // }

  //   public beforeOpen (args: BeforeOpenCloseMenuEventArgs) {
  //     this.filterContextMenu.items = this.filterMenuItems;
  //  }
  /** end */

  private getItems(select?: string, filter?: string, order?: string, group?: string) {
    this.loading = true;
    if (this.navigatorMap.definitie) {
    this.navigatorMapService.getLijstItems(
      this.navigatorMap.definitie.uri, this.navigatorMap.soortInhoud,
      select, filter, order, group).subscribe((result) => {
        this.mainItems = result;
        this.loading = false;
        }, error => {
            this.toast.cssClass = 'e-toast-danger';
            // this.toast.icon = 'fal fa-check-circle';
            this.toast.title = 'Fout met data ophalen';
            if (error.message) {
              this.toast.content = error.message;
            } else {
              this.toast.content = error;
            }
            this.toast.show();
        });
    }
  }

  private sendNotification(data: LijstItem) {
    this.navigatorMapService.itemChanged.next(data);
  }
}

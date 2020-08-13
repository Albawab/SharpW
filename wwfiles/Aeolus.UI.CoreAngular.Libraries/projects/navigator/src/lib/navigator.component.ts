import { Component, OnInit, ViewChild, ViewEncapsulation, Input, Output, EventEmitter } from '@angular/core';
import { TreeViewComponent, NodeSelectEventArgs, DragAndDropEventArgs,
         ContextMenuComponent, MenuItemModel, MenuEventArgs  } from '@syncfusion/ej2-ng-navigations';
import { AutoCompleteComponent } from '@syncfusion/ej2-ng-dropdowns';
import { Router, NavigationEnd } from '@angular/router';
import { NavigatorItem } from './models/navigatorItem';
import { NavigatorService } from './navigator.service';

@Component({
  selector: 'hene-navigator',
  templateUrl: './navigator.component.html',
  styleUrls: ['./navigator.component.scss'],
  encapsulation: ViewEncapsulation.None
})
export class NavigatorComponent implements OnInit {
  @Input() navTitel: string;
  @Input() url: string;
  @ViewChild('tvNav') TreeViewObj: TreeViewComponent;
  // @ViewChild('zoek') public AutoCompleteObj: AutoCompleteComponent;
  @Output() notifyParent: EventEmitter<any> = new EventEmitter();

  isActive = false;
  showMenu = '';
  pushRightClass = 'push-right';

  fields: Object = { value: 'name' };
  fieldsFav: Object = { value: 'name' };

  value = '';
  // waterMark = 'Zoeken';
  waterMark = '';
  height = '250px';
  sorting = 'Ascending';
  allowDragAndDrop = true;
  field: Object = {};
  fieldFav: Object = {};
  viewsData: NavigatorItem[];
  viewsDataFavoriten: NavigatorItem[];
  navItem: NavigatorItem;

  constructor(private router: Router, private navigatorService: NavigatorService
    /*, private changeNavigatorService: ChangeNavigatorService*/) {
      this.router.events.subscribe(val => {
        if (
            val instanceof NavigationEnd &&
            window.innerWidth <= 992 &&
            this.isToggled()
        ) {
            this.toggleSidebar();
        }
    });
  }

  ngOnInit() {
    this.navigatorService.getNavigator(this.url).subscribe((result) => {
      this.viewsData = result;
      this.field = { dataSource: this.viewsData, id: 'id', text: 'titel', parentID: 'parentID', hasChildren: 'hasChildren', url: 'url' };

      this.viewsDataFavoriten = result.filter( function (item) { return item.favorite === true; });

      // console.log('viewsData', this.viewsData);
      // console.log('viewsDataFavoriten', this.viewsDataFavoriten);

      this.fieldFav = { dataSource: this.viewsDataFavoriten, id: 'id', text: 'titel',
                        parentID: 'parentID', hasChildren: 'hasChildren', url: 'url' };
      }, error => {
          console.log(error);
      });

  }

  // onChange(args: any): void {
  //   const valueEle: HTMLInputElement = document.getElementsByClassName('e-input')[0] as HTMLInputElement;
  //   // make empty the input value when typed characters is 'null' in input element
  //   if (this.AutoCompleteObj.value === 'null' || this.AutoCompleteObj.value === null || this.AutoCompleteObj.value === '') {
  //       valueEle.value = '';
  //   } else {
  //     // this.appService.changeZoekTerm(valueEle.value);
  //     this.value = valueEle.value;
  //     this.router.navigateByUrl('/home/' + this.value);
  //   }
  // }

  sendNotification(data: any) {
    this.notifyParent.emit(data);
  }

  onNodeSelected(e: any) {
    const item = this.viewsData.find(elem => elem.id === e.nodeData.id);
    if (item.url) {
      if (item.url === '#') {
        this.sendNotification(null);
      } else {
        this.sendNotification(null);
        window.open(item.url, '_blank');
      }
    } else {
      this.sendNotification(item);
    }
  }

  onNodeDropped(args: DragAndDropEventArgs) {
    console.log(args);
    const item = this.viewsData.find(elem => elem.id === args.draggedNodeData.id);
    const foundIndex = this.viewsData.findIndex(elem => elem.id === args.draggedNodeData.id);
    if (item) {
      // Controlleren dat node niet aria-level 1 is
      if (args.draggedNode.attributes[3].nodeValue !== '1') {
        item.parentID = args.droppedNodeData.id.toString();
      } else {
        item.parentID = null;
      }
    }

    this.viewsData.splice(foundIndex, 1, item);
    console.log(this.viewsData);
  }

  toogleFav(item: any) {
    this.navItem = this.viewsData.find(elem => elem.id === item.id);
    const foundIndex = this.viewsData.findIndex(elem => elem.id === item.id);
    if (this.navItem) {
      this.navItem.favorite = !item.favorite;
      if (this.navItem.favorite) {

      }
      this.viewsData.splice(foundIndex, 1, item);
    }
  }

  doAction(action, data) {
    if (action.action === 'addNode') {
      this.addNode(data);
    }
    if (action.action === 'renameNode') {
      this.renameNode(data);
    }
    if (action.action === 'deleteNode') {
      this.deleteNode(data);
    }
  }

  addNode(data) {
    const item = {id: 0, titel: 'Nieuwe map', parentID: data.id};
    // this.TreeViewObj.addNodes([{id: 0, titel: 'Nieuwe map', parentID: data.id}], data.id, 0);
    this.TreeViewObj.addNodes([item], data.id, 0);
    const navItem = new NavigatorItem(item.id.toString(), item.titel);
    navItem.parentID = item.parentID;
    navItem.actions = [
      { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
      { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
      { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
    ];
    this.viewsData.push(navItem);
    this.TreeViewObj.refresh();
  }

  renameNode(data) {
    this.TreeViewObj.beginEdit(data.id);
  }

  deleteNode(data) {
    const del = confirm('Weet u zeker dat u deze map wilt verwijderen?');
    if (del) {
      this.TreeViewObj.removeNodes(data.id);
    }
    console.log(this.viewsData);
  }

  eventCalled() {
      this.isActive = !this.isActive;
  }

  addExpandClass(element: any) {
      if (element === this.showMenu) {
          this.showMenu = '0';
      } else {
          this.showMenu = element;
      }
  }

  isToggled(): boolean {
      const dom: Element = document.querySelector('body');
      return dom.classList.contains(this.pushRightClass);
  }

  toggleSidebar() {
      const dom: any = document.querySelector('body');
      dom.classList.toggle(this.pushRightClass);
  }

}

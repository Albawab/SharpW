
import { Component, OnInit, ViewChild, ViewEncapsulation, Input, Output, EventEmitter } from '@angular/core';
import { TreeViewComponent, NodeSelectEventArgs, DragAndDropEventArgs,
         ContextMenuComponent, MenuItemModel, MenuEventArgs, BeforeOpenCloseMenuEventArgs  } from '@syncfusion/ej2-ng-navigations';
import { AutoCompleteComponent } from '@syncfusion/ej2-ng-dropdowns';
import { Router, NavigationEnd } from '@angular/router';
import { NavigatorItem } from 'navigator';
import { NavigatorService } from 'navigator';

@Component({
  selector: 'hene-navigator-test',
  templateUrl: './navigator-test.component.html',
  styleUrls: ['./navigator-test.component.scss']
})
export class NavigatorTestComponent implements OnInit {
  @Input() navTitel: string;
  @Input() url: string;
  @ViewChild('tvNav') treeViewObj: TreeViewComponent;
  @ViewChild('contentmenutree') contentmenutree: ContextMenuComponent;
  @Output() notifyParent: EventEmitter<any> = new EventEmitter();
  public index = 1;

  isActive = false;
  showMenu = '';
  pushRightClass = 'push-right';

  fields: Object = { value: 'name' };
  fieldsFav: Object = { value: 'name' };

  value = '';
  height = '250px';
  sorting = 'Ascending';
  allowDragAndDrop = true;
  field: Object = {};
  fieldFav: Object = {};
  viewsData: NavigatorItem[];
  viewsDataFavoriten: NavigatorItem[];
  navItem: NavigatorItem;
  public menuItems: MenuItemModel[] = [
    { text: 'Nieuw map aanmaken' },
    { text: 'Naam wijzigen' },
    { text: 'Verwijderen' }
  ];

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

      // this.viewsDataFavoriten = result.filter( function (item) { return item.favorite === true; });

      console.log('viewsData', this.viewsData);
      // console.log('viewsDataFavoriten', this.viewsDataFavoriten);

      // this.fieldFav = { dataSource: this.viewsDataFavoriten, id: 'id', text: 'titel',
      //                   parentID: 'parentID', hasChildren: 'hasChildren', url: 'url' };

      }, error => {
          console.log(error);
      });

  }

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
    console.log(action);
    console.log(data);

    if (action === 'addNode') {
      this.addNode(data);
    }
    if (action === 'renameNode') {
      this.renameNode(data);
    }
    if (action === 'deleteNode') {
      this.deleteNode(data);
    }
  }

  openContextMenu(event) {
    const target = event.target || event.srcElement || event.currentTarget;
    this.contentmenutree.open(event.clientY, event.clientX, target);
  }

  addNode(parentID) {
    const item = {id: 'new-child-' + this.index, name: 'Nieuwe map', titel: 'Nieuwe map'};
    // this.treeViewObj.addNodes([{id: 0, titel: 'Nieuwe map', parentID: parentID}], parentID, null);
    this.treeViewObj.addNodes([item], parentID, null);
    this.index++;
    const navItem = new NavigatorItem(item.id.toString(), item.titel);
    navItem.parentID = parentID;
    navItem.actions = [
      { naam: 'Nieuw map aanmaken', soort: 'click', action: 'addNode' },
      { naam: 'Naam wijzigen', soort: 'click', action: 'renameNode' },
      { naam: 'Verwijderen', soort: 'click', action: 'deleteNode' }
    ];
    this.viewsData.push(navItem);
    // this.treeViewObj.refresh();
    this.renameNode(item.id.toString());
  }

  renameNode(id) {
    this.treeViewObj.beginEdit(id);
  }

  deleteNode(id) {
    const del = confirm('Weet u zeker dat u deze map wilt verwijderen?');
    if (del) {
      this.treeViewObj.removeNodes([id]);
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

  public toggleSidebar() {
      const dom: any = document.querySelector('body');
      dom.classList.toggle(this.pushRightClass);
  }

  // showActiesMenu(id) {
  //   debugger;
  //   const menu = document.getElementById(id);
  //   menu.style.display = 'block';
  // }

  public menuclick(args: MenuEventArgs) {
    const targetNodeId: string = this.treeViewObj.selectedNodes[0];
    if (args.item.text === 'Nieuw map aanmaken') {
      this.doAction('addNode', targetNodeId);
    } else if (args.item.text === 'Verwijderen') {
      this.doAction('deleteNode', targetNodeId);
    } else if (args.item.text === 'Naam wijzigen') {
      this.doAction('renameNode', targetNodeId);
    }
  }

  public beforeopen(args: BeforeOpenCloseMenuEventArgs) {
    this.menuItems.forEach(menuItem => {
      // this.contentmenutree.enableItems([menuItem.text], false);
      this.contentmenutree.hideItems([menuItem.text]);
    });

    const targetNodeId: string = this.treeViewObj.selectedNodes[0];
    let item = null;
    this.viewsData.forEach(ele => {
      if (ele.id === targetNodeId) {
        item = ele;
        item.actions.forEach(action => {
          // this.contentmenutree.enableItems([action.naam], true);
          this.contentmenutree.showItems([action.naam]);
        });
      }
    });

    // const targetNodeId: string = this.treeViewObj.selectedNodes[0];
    // // const targetNode: Element = document.querySelector('[data-uid="' + targetNodeId + '"]');
    // // if (targetNode.classList.contains('remove')) {
    //     // this.contentmenutree.enableItems(['Remove Item'], false);
    // // } else {
    //     this.contentmenutree.enableItems(['Remove Item'], true);
    // // }
    // // if (targetNode.classList.contains('rename')) {
    //     // this.contentmenutree.enableItems(['Rename Item'], false);
    // // } else {
    //     this.contentmenutree.enableItems(['Rename Item'], true);
    // // }
  }

}

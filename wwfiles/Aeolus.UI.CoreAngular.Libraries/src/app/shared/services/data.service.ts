// AS - Niet voor produtie, alleen voor testen en Syncfunsion code referentie.
import { Injectable } from '@angular/core';
import { TreeViewComponent, ToolbarComponent, AccordionComponent, ContextMenuComponent,
    ClickEventArgs } from '@syncfusion/ej2-ng-navigations';
import { ListViewComponent } from '@syncfusion/ej2-ng-lists';
import { AutoCompleteComponent, ChangeEventArgs } from '@syncfusion/ej2-ng-dropdowns';
import { DialogComponent } from '@syncfusion/ej2-ng-popups';
import { folderData, messageDataSourceNew } from './datasource';

@Injectable({
  providedIn: 'root'
})
export class DataService {

    // Class Members
    public treeDataSource: { [key: string]: Object }[] = folderData;
    public treeviewSelectedData: { [key: string]: Object } = null;
    public treeSelectedElement: HTMLElement = null;
    public selectedFolderName = '';
    public selectedListElement: HTMLElement = null;
    public isItemClick = false;
    public isMenuClick = false;
    private hoverOnPopup = false;
    public ddlReplyAllValue = 'Reply All';
    public dropdownSelect = false;

    // AutoComplete binding properties
    public contactsList: {[key: string]: Object}[] = [];
    public searchFields: Object = { text: 'MailId', value: 'MailId' };

    public grpListObj: ListViewComponent;
    public filterContextMenu: ContextMenuComponent;
    public acrdnObj: AccordionComponent;
    public dlgNewWindow: DialogComponent;
    public dlgSentMail: DialogComponent;
    public dlgSentMailNew: DialogComponent;
    public dlgReplyAllWindow: DialogComponent;
    public toolbarMobile: ToolbarComponent;
    public acSearchMobile: AutoCompleteComponent;
    public treeObj: TreeViewComponent;

    // List View binding properties
    public messageDataSource: { [key: string]: Object }[] = messageDataSourceNew;

    public autoSearchSelect(args: ChangeEventArgs): void {
        if (args.value) {
            const dataSource: { [key: string]: Object }[] = this.messageDataSource;
            this.grpListObj.dataSource = this.getFilteredDataSource(dataSource, 'Email', args.value.toString());
            document.getElementById('spanFilterText').innerHTML = 'All Search';
        } else {
            this.resetSelectedFolderData();
        }
    }



    public getSelectedMessage(): { [key: string]: Object } {
        if (this.grpListObj.getSelectedItems()) {
            const selectedData: { [key: string]: Object } = this.grpListObj.getSelectedItems().data as {};
            const key = 'ContactID';
            for (let i = 0; i < this.messageDataSource.length; i++) {
                if (this.messageDataSource[i][key].toString() === selectedData[key].toString()) {
                    return this.messageDataSource[i];
                }
            }
        }
        return null;
    }

    public getFilteredDataSource(dataSource: { [key: string]: Object }[], columnName: string, columnValue: string):
    { [key: string]: Object }[] {
        // tslint:disable-next-line:no-shadowed-variable
        const folderData: { [key: string]: Object }[] = [];
        for (let i = 0; i < dataSource.length; i++) {
            const data: { [key: string]: Object } = dataSource[i];
            if (data[columnName] && data[columnName].toString() === columnValue) {
                folderData.push(data);
            }
        }
        return folderData;
    }




    public setReadCount(readType: string): void {
        const selectedFolder: HTMLCollectionOf<HTMLElement> =
        document.getElementsByClassName('treeCount ' + this.selectedFolderName) as HTMLCollectionOf<HTMLElement>;
        for (let i = 0; i < selectedFolder.length; i++) {
            let count: number = selectedFolder[i].innerHTML  === '' ? 0 : Number(selectedFolder[i].innerHTML);
            if (readType === 'Unread') {
                if (count > 0) {
                    count -= 1;
                }
            } else {
                count += 1;
            }
            selectedFolder[i].innerHTML = count === 0 ? '' : count.toString();
        }
    }



    public resetSelectedFolderData(): void {
        document.getElementById('spanFilterText').innerHTML = this.selectedFolderName;
        const dataSource: { [key: string]: Object }[] =
        this.getFilteredDataSource(this.messageDataSource, 'Folder', this.selectedFolderName);
        this.grpListObj.dataSource = dataSource;
        this.clearFilterMenu();
        this.filterContextMenu.items[0].iconCss = 'ej-icon-Right';
        this.filterContextMenu.dataBind();
    }

    public clearFilterMenu(): void {
        for (let i = 0; i < this.filterContextMenu.items.length; i++) {
            if (this.filterContextMenu.items[i].items.length === 0) {
                this.filterContextMenu.items[i].iconCss = '';
            }
        }
    }
    public cloneObject(obj: { [key: string]: Object }): { [key: string]: Object } {
        const keys: string[] = Object.keys(obj);
        const cloneObject: { [key: string]: Object } = {};
        for (let i = 0; i < keys.length; i++) {
            cloneObject[keys[i]] = obj[keys[i]];
        }
        return cloneObject;
    }
    public popupMouseEnter(): void {
        this.hoverOnPopup = true;
    }


    public hideSideBar(): void {
        if (!this.isMenuClick) {
            const sidebar: Element = document.getElementsByClassName('sidebar')[0];
            if (sidebar.className.indexOf('sidebar show') !== -1) {
                sidebar.className = 'sidebar';
                const overlayElement: Element = document.getElementsByClassName('overlay-element')[0];
                overlayElement.className = 'overlay-element';
            }
        }
        this.isMenuClick = false;
    }

    constructor() {
    }
}

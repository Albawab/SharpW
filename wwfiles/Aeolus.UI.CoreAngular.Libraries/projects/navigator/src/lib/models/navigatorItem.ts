export class NavigatorItem {
  constructor(public id: string, public titel: string) {
  }

  parentID?: string;
  hasChildren?: boolean;
  expanded?: boolean;
  soort?: string;
  status?: number;
  uri?: string;
  url?: string;
  favorite?: boolean;
  actions?: Action[];
}

export class Action {
  id?: string;
  naam: string;
  soort?: string; // click or ref
  action?: string; // add, rename, delete, https://www.google.nl
}

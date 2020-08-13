export class NavigatorMap {
  titel: string;
  uri?: string;
  omschrijving?: string;
  filter?: string;
  select?: string;
  orderBy?: string;
  groupBy?: string;
  soortInhoud?: string;
  filterOptions?: TitelValue[];
  orderByOptions?: TitelValue[];
  groupByOptions?: TitelValue[];
  definitie: Definitie;
  navigatorMapActies?: any[];
}

export class Definitie {
  uri: string;
  select?: string;
  filter?: string;
  group?: string;
}

export class TitelValue {
  titel: string;
  value?: string;
  // id?: any;
  // parentId?: any;
  selected?: boolean;
}

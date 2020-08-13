import { KeyValuePair } from './keyValuePair';
import { SoortItem } from './enums';

export class PreviewItem {
  id: string;
  titel: string;
  icon?: string;
  omschrijving?: string;
  soort?: SoortItem;
  datum?: Date;
  status?: number;
  uri?: string;
  extras?: KeyValuePair[];
  acties?: any[];
  onderdelen?: Onderdeel[];
}

export class Onderdeel {
  id: string;
  titel?: string;
  uri?: string;
  acties?: any;
  soort?: any;

}

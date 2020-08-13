import { KeyValuePair } from './keyValuePair';

export class LijstItem {
  id: string;
  titel: string;
  omschrijving?: string;
  datum?: Date;
  status?: number;
  uri?: string;
  extras?: KeyValuePair[];
}

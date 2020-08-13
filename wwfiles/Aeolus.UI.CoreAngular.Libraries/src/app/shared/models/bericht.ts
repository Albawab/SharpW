import { KeyValuePair } from './keyValuePair';

export interface Bericht {
  id: string;
  titel: string;
  omschrijving?: string;
  datum?: Date;
  status?: number;
  uri?: string;
  extras?: any[];
}

export interface Bericht2 {
  Id?: string;
  IdBerichtDef?: string;
  Uitgaand?: number;
  CBerichtStatus?: number;
  CPrioriteit?: number;
  DatumAangemaakt?: Date;
  DatumVerzonden?: Date;
  Volgnr?: number;
  extras?: KeyValuePair[];
}

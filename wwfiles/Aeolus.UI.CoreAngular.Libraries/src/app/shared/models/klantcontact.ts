import { KeyValuePair } from './keyValuePair';

export class Klantcontact {
  Id: string;
  Soort?: number;
  SoortNaam?: string;
  SubSoortId?: number;
  SubSoortNaam?: string;
  Status?: number;
  Onderwerp?: string;
  Locatie?: string;
  Prioriteit?: number;
  Begindatum?: Date;
  DoenVoor?: Date;
  Einddatum?: Date;
  BeschikbaarGebruikers?: any[] = [];
  UitvoeringDoor?: string;
  GemeldDoor?: string;
  Subjecten?: any[] = [];
  PrivacySoort?: number;
  Inhoud?: string;
  ControlPrivacyEnable?: Boolean;
  isAanmaker?: Boolean;
  AangemaaktDoor?: KeyValuePair;
  AanmaakDatum?: Date;
  Bestanden?: any[] = [];
  BestandenToDelete?: any[] = [];
  BestedeTijden?: any[] = [];
  BestedeTijdenToDelete?: any[] = [];
  TijdenDoor?: string;
  SubSoorten?: string;
  MeenemenInVerslag?: Boolean;
}

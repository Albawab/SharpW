export interface Klant {
  id: string;
  naam: string;
  omschrijving?: string;
  geboortedatum?: Date;
  status?: number;
  uri?: string;
  extras?: any[];
}

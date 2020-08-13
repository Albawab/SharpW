export class BaseSubActie {
  id?: string;
  type: string;
  voerUitOpAlleItems: string;
  soort: string;
  returnFailedResult: string;
  returnSuccesResult: string;
}

export class OpenSubActie extends BaseSubActie {
  url: string;
  target: string;
}

export class ConfirmSubActie extends BaseSubActie {
  vraag: string;
}

export class ApiCallSubActie extends BaseSubActie {

}

export class EditSubActie extends BaseSubActie {
  path: string;
}

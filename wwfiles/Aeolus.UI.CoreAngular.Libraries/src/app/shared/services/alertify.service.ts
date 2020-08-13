import { Injectable } from '@angular/core';

declare let alertify: any;

@Injectable({
  providedIn: 'root'
})
export class AlertifyService {

  confirm(message: string, okCallback: () => any) {
    alertify.confirm(message, function(e) {
      if (e) {
        okCallback();
      } else {

      }
    }).setHeader('Aeolus Berichten').set({transition: 'zoom'});
  }

  success(message: string) {
    alertify.success(message);
  }

  error(message: string) {
    alertify.error(message);
  }

  warning(message: string) {
    alertify.warning(message);
  }

  message(message: string) {
    alertify.message(message);
  }

  prompt(message: string, value: any, okCallback: (val) => any) {
    alertify.prompt('Aeolus Berichten', message, value || '',
                function(evt, val) { okCallback(val); },
                function() { }).set({transition: 'zoom'});
  }
}

import { Component, OnInit } from '@angular/core';
import { OpenIdConnectService } from '../shared/services/open-id-connect.service';

@Component({
  selector: 'hene-redirect-silent-renew',
  templateUrl: './redirect-silent-renew.component.html',
  styleUrls: ['./redirect-silent-renew.component.scss']
})
export class RedirectSilentRenewComponent implements OnInit {

  constructor(private openIdConnectService: OpenIdConnectService) { }

  ngOnInit() {
      this.openIdConnectService.handleSilentCallback();
  }
}

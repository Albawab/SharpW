// This file can be replaced during build by using the `fileReplacements` array.
// `ng build ---prod` replaces `environment.ts` with `environment.prod.ts`.
// The list of file replacements can be found in `angular.json`.

export const environment = {
  production: false,
  openIdConnectSettings: {
    authority: 'http://localhost:5000/', // authority: 'http://localhost:52934/',
    client_id: 'mvc',
    client_secret: 'secret',
    redirect_uri: 'http://localhost:4200/signin-oidc',
    scope: 'openid profile api1 offline_access',
    response_type: 'code id_token token',
    post_logout_redirect_uri: 'http://localhost:4200/',
    automaticSilentRenew: true,
    silent_redirect_uri: 'http://localhost:4200/redirect-silentrenew',
    loadUserInfo: true,
    filterProtocolClaims: true
  }
};

/*
 * In development mode, to ignore zone related error stack frames such as
 * `zone.run`, `zoneDelegate.invokeTask` for easier debugging, you can
 * import the following file, but please comment it out in production mode
 * because it will have performance impact when throw error
 */
// import 'zone.js/dist/zone-error';  // Included with Angular CLI.

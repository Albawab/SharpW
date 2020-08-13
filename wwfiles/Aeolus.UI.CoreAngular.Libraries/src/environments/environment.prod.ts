export const environment = {
  production: true,
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

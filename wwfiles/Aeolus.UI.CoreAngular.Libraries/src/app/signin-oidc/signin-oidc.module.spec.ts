import { SigninOidcModule } from './signin-oidc.module';

describe('signinOidcModule', () => {
    let signinOidcModule: SigninOidcModule;

    beforeEach(() => {
        signinOidcModule = new SigninOidcModule();
    });

    it('should create an instance', () => {
        expect(signinOidcModule).toBeTruthy();
    });
});

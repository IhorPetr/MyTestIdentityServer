using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens;
using Microsoft.AspNet.Identity;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.Security.Cookies;
using Microsoft.Owin.Security.OpenIdConnect;
using Owin;
using System.Net;
using Microsoft.Owin.Security;

[assembly: OwinStartupAttribute(typeof(MVCFRAMEWORKCLENT.Startup))]
namespace MVCFRAMEWORKCLENT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            JwtSecurityTokenHandler.InboundClaimTypeMap = new Dictionary<string, string>();

            app.UseCookieAuthentication(new CookieAuthenticationOptions
            {
                AuthenticationType = "Cookies"
            });

            app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            {
                ClientId = "mvc2",
                ClientSecret = "secret",
                AuthenticationType = "oidc",
                Authority = "http://localhost:5000",
                RedirectUri = "http://localhost:64440/signin-oidc",
               ResponseType = "code id_token",
                UseTokenLifetime = false,
                SignInAsAuthenticationType = "Cookies",
            });
            ConfigureAuth(app);
        }
    }
}

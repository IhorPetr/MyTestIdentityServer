using System;
using Microsoft.Owin;
using Microsoft.Owin.Extensions;
using Microsoft.Owin.Security.Cookies;
using Owin;

[assembly: OwinStartupAttribute(typeof(MVCFRAMEWORKCLENT.Startup))]
namespace MVCFRAMEWORKCLENT
{
    public partial class Startup
    {
        public void Configuration(IAppBuilder app)
        {
            ConfigureAuth(app);
            //app.UseCookieAuthentication(new CookieAuthenticationOptions()
            //{
            //    AuthenticationType = "Cookies",
            //    ExpireTimeSpan = TimeSpan.FromMinutes(10),
            //    SlidingExpiration = true
            //});

            //JwtSecurityTokenHandler.InboundClaimTypeMap.Clear();

            //app.UseOpenIdConnectAuthentication(new OpenIdConnectAuthenticationOptions
            //{
            //    AuthenticationType = "oidc",
            //    SignInAsAuthenticationType = "Cookies",
            //    Authority = "http://localhost:5000/",
            //    RedirectUri = "http://localhost:5002/signin-oidc",
            //    ClientId = "mvc",
            //    ResponseType = "id_token",
            //    Scope = "openid profile",
            //    UseTokenLifetime = false
            //});
            //app.UseStageMarker(PipelineStage.Authenticate);
        }
    }
}

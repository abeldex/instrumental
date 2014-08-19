using System;
using System.Collections.Generic;
using System.Linq;
using System.Web;
using Microsoft.AspNet.Membership.OpenAuth;

namespace instrumental_wbforrms
{
    internal static class AuthConfig
    {
        public static void RegisterOpenAuth()
        {
            // Consulte http://go.microsoft.com/fwlink/?LinkId=252803 para obtener más detalles sobre la configuración esta aplicación ASP.NET
            // para que admita el inicio de sesión mediante servicios externos.

            //OpenAuth.AuthenticationClients.AddTwitter(
            //    consumerKey: "su clave de consumidor de Twitter",
            //    consumerSecret: "su secreto de consumidor de Twitter");

            OpenAuth.AuthenticationClients.AddFacebook(
                appId: "1438083416417638",
                appSecret: "35be2625c5e8cd24736418781a189d1f");

            //OpenAuth.AuthenticationClients.AddMicrosoft(
            //    clientId: "su id de cliente de cuenta de Microsoft",
            //    clientSecret: "su secreto de cliente de cuenta de Microsoft");

            //OpenAuth.AuthenticationClients.AddGoogle();
        }
    }
}
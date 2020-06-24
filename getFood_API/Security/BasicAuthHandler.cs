using getFood_API.Services;
using getFood_Model;
using Microsoft.AspNetCore.Authentication;
using Microsoft.Extensions.Logging;
using Microsoft.Extensions.Options;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Net.Http;
using System.Net.Http.Headers;
using System.Security.Claims;
using System.Security.Principal;
using System.Text;
using System.Text.Encodings.Web;
using System.Threading;
using System.Threading.Tasks;
using System.Web.Http.Controllers;

namespace getFood_API.Security
{
    public class BasicAuthHandler : AuthenticationHandler<AuthenticationSchemeOptions>
    {
        private readonly IKorisnikServis _userService;

        public BasicAuthHandler(
            IOptionsMonitor<AuthenticationSchemeOptions> options,
            ILoggerFactory logger,
            UrlEncoder encoder,
            ISystemClock clock,
            IKorisnikServis userService)
            : base(options, logger, encoder, clock)
        {
            _userService = userService;
        }
        
        protected override async Task<AuthenticateResult> HandleAuthenticateAsync()
        {
            if (!Request.Headers.ContainsKey("Authorization"))
                return  AuthenticateResult.Fail("Missing Authorization Header");

           MKorisnik user = null;
            try
            {
                var authHeader = AuthenticationHeaderValue.Parse(Request.Headers["Authorization"]);
                var credentialBytes = Convert.FromBase64String(authHeader.Parameter);
                var credentials = Encoding.UTF8.GetString(credentialBytes).Split(':');
                var username = credentials[0];
                var password = credentials[1];
                user =  await _userService.Authenticate(username, password);
               
            }
            catch
            {
                return AuthenticateResult.Fail("Invalid Authorization Header");
            }

            if (user == null)
                return AuthenticateResult.Fail("Invalid Username or Password");

            var claims = new List<Claim> { //claim je nesto sto mi tvrdimo da postoji
                new Claim(ClaimTypes.NameIdentifier, user.KorisnickoIme),
                new Claim(ClaimTypes.Name, user.Ime),
            };

            foreach (var role in user.KorisnikUloga)
            {
                claims.Add(new Claim(ClaimTypes.Role, role.Uloga.Naziv));
            }

            var identity = new ClaimsIdentity(claims, Scheme.Name);
            var principal = new ClaimsPrincipal(identity);
            var ticket = new AuthenticationTicket(principal, Scheme.Name);

            Thread.CurrentPrincipal = principal;
           
            return AuthenticateResult.Success(ticket);
        }
    }
}

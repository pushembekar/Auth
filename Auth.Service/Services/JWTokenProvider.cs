using Auth.Service.Infrastructure;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace Auth.Service.Services
{
    public class JWTokenProvider : ITokenProvider
    {
        public void ProvideSecurityToken()
        {
            var claims = new[]
            {
                new Claim(ClaimTypes.Name, "Pushkar")
            };

            var key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes("123123123123123123123"));
            var creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);

            var token = new JwtSecurityToken(
                    issuer: "thisdomain.com",
                    audience: "thisdomain.com",
                    expires: DateTime.Now.AddMinutes(30),
                    signingCredentials: creds);

            var tokenvalue = new JwtSecurityTokenHandler().WriteToken(token);
        }
    }
}

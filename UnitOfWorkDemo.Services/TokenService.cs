using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;
using UnitOfWorkDemo.Core.Interfaces;

namespace PMS.Services
{
    public class TokenService
    {
        private readonly IUnitOfWork _unitOfWork;
        private readonly string _defaultAudience;
        private string _defaultIssuerValue;

        public TokenService(IUnitOfWork unitOfWork, string defaultIssuer, string defaultAudience)
        {
            _unitOfWork = unitOfWork;
            _defaultIssuerValue = defaultIssuer;
            _defaultAudience = defaultAudience;
        }

        public string DefaultIssuer
        {
            get { return _defaultIssuerValue; }
            set { _defaultIssuerValue = value; }
        }

        public string DefaultAudience
        {
            get { return _defaultAudience; }
        }

        public string GenerateToken(string secretKey, string issuer, string audience, string username)
        {
            var tokenHandler = new JwtSecurityTokenHandler();
            var key = Encoding.UTF8.GetBytes(secretKey);

            var claims = new[]
            {
            new Claim(ClaimTypes.Name, username)
        };

            var tokenDescriptor = new SecurityTokenDescriptor
            {
                Subject = new ClaimsIdentity(claims),
                Expires = DateTime.UtcNow.AddHours(24), // Token expiration time
                SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256Signature),
                Issuer = DefaultIssuer,
                Audience = DefaultAudience,
            };

            var token = tokenHandler.CreateToken(tokenDescriptor);
            return tokenHandler.WriteToken(token);
        }

     
    }
}

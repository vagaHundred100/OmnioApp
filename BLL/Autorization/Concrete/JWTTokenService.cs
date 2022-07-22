using BLL.Autorization.Abstract;
using DAL.Domains;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Text;
using System.Threading.Tasks;

namespace BLL.Autorization.Concrete
{
    public class JWTTokenService : IJWTTokenService
    {
        public string GenerateJwt(IUserClaimsOptions user, IList<string> roles, IJWTOptions jwtSettings)
        {
            try
            {
                List<Claim> claims = new List<Claim>
                                            {
                                                new Claim(JwtRegisteredClaimNames.Sub, user.Id),
                                                new Claim(ClaimTypes.Name, user.UserName),
                                                new Claim(JwtRegisteredClaimNames.Jti, Guid.NewGuid().ToString()),
                                            };

                IEnumerable<Claim> roleClaims = roles.Select(r => new Claim(ClaimTypes.Role, r));
                claims.AddRange(roleClaims);

                SymmetricSecurityKey key = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(jwtSettings.SecretKey));
                SigningCredentials creds = new SigningCredentials(key, SecurityAlgorithms.HmacSha256);
                DateTime accessTokenExpiration = DateTime.Now.AddYears(Convert.ToInt32(jwtSettings.ExpirationInYears));

                JwtSecurityToken token = new JwtSecurityToken(
                    issuer: jwtSettings.Issuer,
                    audience: jwtSettings.Audience,
                    claims: claims,
                    expires: accessTokenExpiration,
                    signingCredentials: creds
                );

                return new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                return ex.Message;
            }
        }
    }
    
}

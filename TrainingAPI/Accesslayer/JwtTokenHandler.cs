using DataAccess.Model;
using Microsoft.IdentityModel.Tokens;
using System.IdentityModel.Tokens.Jwt;
using System.Text;

namespace TrainingAPI.Accesslayer
{
    public class JwtTokenHandler
    {
        private readonly IConfiguration _config;

        public JwtTokenHandler(IConfiguration config)
        {

            _config = config;
        }

        public string GetToken(Users users)
        {
            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(_config["Jwt:Key"]));

            var credientials = new SigningCredentials(securityKey,SecurityAlgorithms.HmacSha256);

            var secToken = new JwtSecurityToken(_config["Jwt:Issuer"], _config["Jwt:Issuer"], null, expires: DateTime.Now.AddMinutes(2), signingCredentials: credientials);

            var token = new JwtSecurityTokenHandler().WriteToken(secToken);
            return token.ToString();
        }





    } 


}

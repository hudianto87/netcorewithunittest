using Int.Api.Victoria.BusinessLayer.BindingModel;
using Int.Api.Victoria.BusinessLayer.BindingModelResult;
using Int.Api.Victoria.DataAccess.Context;
using Microsoft.Extensions.Configuration;
using Microsoft.IdentityModel.Tokens;
using Newtonsoft.Json;
using System.IdentityModel.Tokens.Jwt;
using System.Security.Claims;
using System.Text;

namespace Int.Api.Victoria.BusinessLayer.BusinessObject
{
    public class BOToken
    {
        private readonly ResponseCode.ResponseCode responseCode;
        private readonly IConfiguration _config;
        private readonly BOLogger boLogger;
        public BOToken(IConfiguration configuration, DBContext db)
        {
            responseCode = new();
            _config = configuration;
            boLogger = new(db);
        }
        public Task<ResultBase<BMRToken>> GenerateToken(BMToken request)
        {
            var result = new ResultBase<BMRToken>()
            {
                Data = new()
            };
            string configApiKey = _config["Jwt:ApiKey"];
            try
            {
                if (!request.apiKey.Equals(configApiKey))
                {
                    result.IsOk = false;
                    result.Message = responseCode.GetEnumDesc(ResponseCode.ResponseCode.errorList.WMS111);
                    result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS111.ToString();
                    return Task.FromResult(result);
                }

                var signingKey = Encoding.UTF8.GetBytes(_config["Jwt:Key"]);
                var securityKey = new SymmetricSecurityKey(signingKey);
                var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);
                double sessionExpired = double.Parse(_config["Jwt:SessionExpired"]);

                var claims = new[] 
                {
                    new Claim(JwtRegisteredClaimNames.Sub, request.userName),
                    new Claim("host", request.host)
                };

                var token = new JwtSecurityToken(_config["Jwt:Issuer"],_config["Jwt:Issuer"],claims,expires: DateTime.Now.AddMinutes(sessionExpired),signingCredentials: credentials);
                result.Data.Token = new JwtSecurityTokenHandler().WriteToken(token);
            }
            catch (Exception ex)
            {
                result.IsOk = false;
                result.Message = ex.Message;
                result.ResponseCode = ResponseCode.ResponseCode.errorList.WMS999.ToString();
            }
            finally
            {
                _ = boLogger.SaveLog("IN", request.host.Trim(), "Service Token", "Token", "", null,
                                    "", JsonConvert.SerializeObject(request), JsonConvert.SerializeObject(result), result.ResponseCode,
                                    result.Message, result.Message, request.userName.Trim(), DateTime.Now);
            }

            return Task.FromResult(result);
        }
    }
}

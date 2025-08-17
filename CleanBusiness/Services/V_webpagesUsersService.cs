using CleanBase.Entities;
using CleanBusiness.Declarations;
using CleanOperation.Declarations;
using Microsoft.IdentityModel.Tokens;
using System;
using System.Collections.Generic;
using System.IdentityModel.Tokens.Jwt;
using System.Linq;
using System.Security.Claims;
using System.Security.Cryptography;
using System.Text;
using System.Threading.Tasks;

namespace CleanBusiness.Services
{
    public class V_webpagesUsersService : RootService<V_webpagesUsers>, IV_webpagesUsers
    {
        public V_webpagesUsersService(IRepository<V_webpagesUsers> repository) : base(repository)
        {
        }

        public Task<string> CreateToken(V_webpagesUsers entity)
        {
            return Task.FromResult(Token(entity)); // Wrap the string in a Task
        }

        public string Token(V_webpagesUsers userInfo)
        {
            // Secret Key for JWT generation (should come from appsettings.json ideally)
            var secretKey = GenerateRandomKey(32); // Ideally from appsettings.json

            if (string.IsNullOrEmpty(secretKey))
            {
                throw new Exception("JWT SecretKey is missing in configuration.");
            }

            var securityKey = new SymmetricSecurityKey(Encoding.UTF8.GetBytes(secretKey));
            var credentials = new SigningCredentials(securityKey, SecurityAlgorithms.HmacSha256);

            // Extract relevant user details
            string userId = userInfo.Id.ToString(); // Main User ID (GUID)
            string userName = userInfo.UserName;    // Username
            string role = userInfo.WebPagesGroupsno.ToString(); // Role (GUID)

            // Define JWT Claims
            var claims = new[]
            {
            new Claim(JwtRegisteredClaimNames.Sub, userId),  // User ID
            new Claim(JwtRegisteredClaimNames.Name, userName), // Username
            new Claim(ClaimTypes.Role, role),  // Role as GUID
            new Claim("WebPagesGroupsno", role),  // Custom claim for Role (GUID)
            new Claim(JwtRegisteredClaimNames.Iat,
                      DateTimeOffset.UtcNow.ToUnixTimeSeconds().ToString(),
                      ClaimValueTypes.Integer64)
        };

            // Generate JWT Token
            var token = new JwtSecurityToken(
                //issuer: "https://yourdomain.com", // Optional: Replace with actual issuer
                //audience: "https://yourfrontend.com", // Optional: Replace with actual audience
                claims: claims,
                expires: DateTime.UtcNow.AddHours(4),
                signingCredentials: credentials
            );

            // Convert Token to String
            return new JwtSecurityTokenHandler().WriteToken(token);
        }

        public static string GenerateRandomKey(int size)
        {
            using (var rng = RandomNumberGenerator.Create())
            {
                var key = new byte[size];
                rng.GetBytes(key);

                // Convert to base64 for easier storage/transfer
                return Convert.ToBase64String(key);
            }
        }
    }
}

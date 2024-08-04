using System.Net;
using TokenApp.Models;
using TokenApp.Services.Interfaces;

namespace TokenApp.Services
{
    /// <summary>
    /// Service used to Build and refactor Token Token
    /// For now least permission is given
    /// </summary>
    public class TokenBuilderService : ITokenBuilder
    {
        /// <summary>
        /// Build Token with minimal configurations
        /// </summary>
        /// <param name="user"></param>
        /// <param name="privileges"></param>
        /// <returns></returns>
        public Token buildToken(User user, List<Priviledge> privileges)
        {
            Token _token =
             new Token()
             .addId(Guid.NewGuid().ToString())
             .addAudience("_self_")
             .addIssuer(Dns.GetHostName())
             .addIssued(DateTime.Now.ToString())
             .addExpired(DateTime.Now.AddMinutes(Constants.durationOfToken).ToString())
             .addType("Reference");

            _token.privileges = privileges;

            return _token;
        }

        /// <summary>
        /// Refactor Toke  with given extra added privilege
        /// </summary>
        /// <param name="token"></param>
        /// <param name="privileges"></param>
        /// <returns></returns>
        public Token refactorToken(Token token, Priviledge privileges)
        {
            Token refactorToken = new Token()
                .addPrivilege(privileges);
            return refactorToken;
        }
    }
}

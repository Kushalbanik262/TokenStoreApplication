using TokenApp.Exceptions;
using TokenApp.Models;
using TokenApp.Services.Interfaces;

namespace TokenApp.Services
{
    public class InMemoryTokenStorageService : ITokenOperation
    {
        private static Dictionary<string, Token> _inMemoryTokenStorage;
        private static Dictionary<string, User> _inMemoryUserStorage;

        private ITokenBuilder _tokenBuilder;
        private ILogger _logger;

        public InMemoryTokenStorageService(ITokenBuilder tokenBuilder,ILogger logger) { 
            _inMemoryTokenStorage = new Dictionary<string, Token>();
            _inMemoryUserStorage = new Dictionary<string, User>();
            _tokenBuilder = tokenBuilder;
            _logger = logger;
        }

        /// <summary>
        /// Issue the token based on InMemory References
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="privileges"></param>
        /// <returns></returns>
        /// <exception cref="UserNotFoundException"></exception>
        public Token issueToken(string userId, List<Priviledge> privileges)
        {
            User _user;
            _inMemoryUserStorage.TryGetValue(userId,out _user);
            if(_user == null) {
                _logger.LogError("User Not Found with perticular Id");
                throw new UserNotFoundException("No User Found with Username:"+userId); }

            _logger.LogDebug("User Found for Token Creation:{}",_user);

            Token token = _tokenBuilder.buildToken(_user, privileges);
            _logger.LogInformation("Token Generated:{}", token);

            return token;

        }

        public Token removeToken(string tokenId)
        {
            throw new NotImplementedException();
        }

        public Token updateToken(string tokenId, List<Priviledge> updatedPrivileges)
        {
            throw new NotImplementedException();
        }
    }
}

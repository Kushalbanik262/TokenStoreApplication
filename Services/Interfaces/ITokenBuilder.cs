using TokenApp.Models;

namespace TokenApp.Services.Interfaces
{
    /// <summary>
    /// Interface used for building the token
    /// </summary>
    public interface ITokenBuilder
    {
        /// <summary>
        /// Build Token based on the user and given privileges
        /// </summary>
        /// <param name="user"></param>
        /// <param name="privileges"></param>
        /// <returns></returns>
        public Token buildToken(User user,List<Priviledge> privileges);

        /// <summary>
        /// Refactor Token based on new given privileges
        /// </summary>
        /// <param name="token"></param>
        /// <param name="privileges"></param>
        /// <returns></returns>
        public Token refactorToken(Token token,Priviledge privileges);    

    }
}

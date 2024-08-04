using TokenApp.Models;

namespace TokenApp.Services.Interfaces
{
    public interface ITokenOperation
    {
        /// <summary>
        /// Issueing a token based upon any specific user and some privileges
        /// </summary>
        /// <param name="userId"></param>
        /// <param name="privileges"></param>
        /// <returns></returns>
        public Token issueToken(string userId, List<Priviledge> privileges);

        /// <summary>
        /// Updating a token based on new privileges and adding the same
        /// </summary>
        /// <param name="tokenId"></param>
        /// <param name="updatedprivileges"></param>
        /// <returns></returns>
        public Token updateToken(string tokenId,List<Priviledge> updatedPrivileges);

        /// <summary>
        /// Removing an existing token
        /// </summary>
        /// <param name="tokenId"></param>
        /// <returns></returns>
        public Token removeToken(string tokenId);
    }
}

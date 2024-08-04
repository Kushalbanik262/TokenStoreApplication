using TokenApp.Models;

namespace TokenApp.Services.Interfaces
{
    /// <summary>
    /// This abstruction the storage options
    /// </summary>
    public interface IStorageOperations
    {
        /// <summary>
        /// Fetching all the users by UserID
        /// </summary>
        /// <param name="userId">UserId</param>
        /// <returns>The User</returns>
        public User fetchUserByUserId(string userId);
        
        /// <summary>
        /// Fetch Token by Token Id
        /// </summary>
        /// <param name="tokenId">The id of the token we want to fetch</param>
        /// <returns>The token</returns>
        public Token fetchTokenByTokenId(string tokenId);
    }
}

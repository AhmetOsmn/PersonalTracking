using Model;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Includes opeartions signatures.
    /// </summary>
    public interface IUserRepository 
    {
        /// <summary>
        /// Get all users.
        /// </summary>
        IEnumerable<UserVM> GetAll();

        /// <summary>
        /// Get user by id.
        /// </summary>
        /// <param name="id">User's id.</param>
        UserVM GetById(short id);

        /// <summary>
        /// Create user.
        /// </summary>
        /// <param name="operationTypeVM">Includes user's values.</param>
        Task Create(UserVM userVM);

        /// <summary>
        /// Update user.
        /// </summary>
        /// <param name="operationTypeVM">Includes user's values.</param>
        Task Update(UserVM userVM);

        /// <summary>
        /// Delete user.
        /// </summary>
        /// <param name="id">User's id</param>
        Task Delete(int id);
    }
}

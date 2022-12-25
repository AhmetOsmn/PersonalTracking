using Model;

namespace Business.Abstract
{
    /// <summary>
    /// UserRole service.
    /// </summary>
    public interface IUserRoleService
    {
        /// <summary>
        /// Get all userRole datas.
        /// </summary>
        Task<IEnumerable<UserRoleVM>> GetAll();

        /// <summary>
        /// Get userRole by id.
        /// </summary>
        /// <param name="id">UserRole's id.</param>
        Task<UserRoleVM> GetById(short id);

        /// <summary>
        /// Create userRole.
        /// </summary>
        /// <param name="operationTypeVM">Includes userRole's values.</param>
        Task Create(UserRoleVM userRoleVM);

        /// <summary>
        /// Update userRole.
        /// </summary>
        /// <param name="operationTypeVM">Includes userRole's values.</param>
        Task Update(UserRoleVM userRoleVM);

        /// <summary>
        /// Delete userRole.
        /// </summary>
        /// <param name="id">UserRole's id</param>
        Task Delete(int id);
    }
}

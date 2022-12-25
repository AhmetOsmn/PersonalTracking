using Model;

namespace Business.Abstract
{
    /// <summary>
    /// Role service.
    /// </summary>
    public interface IRoleService
    {
        /// <summary>
        /// Get all roles.
        /// </summary>
        Task<IEnumerable<RoleVM>> GetAll();

        /// <summary>
        /// Get role by id.
        /// </summary>
        /// <param name="id">Role's id.</param>
        Task<RoleVM> GetById(short id);

        /// <summary>
        /// Create role type.
        /// </summary>
        /// <param name="operationTypeVM">Includes role's values.</param>
        Task Create(RoleVM roleVM);

        /// <summary>
        /// Update role type.
        /// </summary>
        /// <param name="operationTypeVM">Includes role's values.</param>
        Task Update(RoleVM roleVM);

        /// <summary>
        /// Delete role.
        /// </summary>
        /// <param name="id">Role's id</param>
        Task Delete(int id);
    }
}

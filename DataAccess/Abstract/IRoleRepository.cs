using Model;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Includes opeartions signatures.
    /// </summary>
    public interface IRoleRepository 
    {
        /// <summary>
        /// Get all roles.
        /// </summary>
        IEnumerable<RoleVM> GetAll();

        /// <summary>
        /// Get role by id.
        /// </summary>
        /// <param name="id">Role's id.</param>
        RoleVM GetById(short id);

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

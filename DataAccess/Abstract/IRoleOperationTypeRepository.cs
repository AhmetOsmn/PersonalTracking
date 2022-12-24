using Model;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Includes opeartions signatures.
    /// </summary>
    public interface IRoleOperationTypeRepository 
    {
        /// <summary>
        /// Get all roleOperationType datas.
        /// </summary>
        IEnumerable<RoleOperationTypeVM> GetAll();

        /// <summary>
        /// Get roleOperationType by id.
        /// </summary>
        /// <param name="id">RoleOperationType's id.</param>
        RoleOperationTypeVM GetById(short id);

        /// <summary>
        /// Create roleOperationType.
        /// </summary>
        /// <param name="operationTypeVM">Includes roleOperationType's values.</param>
        Task Create(RoleOperationTypeVM roleOperationTypeVM);

        /// <summary>
        /// Update roleOperationType.
        /// </summary>
        /// <param name="operationTypeVM">Includes roleOperationType's values.</param>
        Task Update(RoleOperationTypeVM roleOperationTypeVM);

        /// <summary>
        /// Delete roleOperation.
        /// </summary>
        /// <param name="id">RoleOperation's id</param>
        Task Delete(int id);
    }
}

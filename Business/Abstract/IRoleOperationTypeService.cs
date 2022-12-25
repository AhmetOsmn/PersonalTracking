using Model;

namespace Business.Abstract
{
    /// <summary>
    /// RoleOperationType service.
    /// </summary>
    public interface IRoleOperationTypeService
    {
        /// <summary>
        /// Get all roleOperationType datas.
        /// </summary>
        Task<IEnumerable<RoleOperationTypeVM>> GetAll();

        /// <summary>
        /// Get roleOperationType by id.
        /// </summary>
        /// <param name="id">RoleOperationType's id.</param>
        Task<RoleOperationTypeVM> GetById(short id);

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

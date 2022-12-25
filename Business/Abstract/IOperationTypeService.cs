using Model;

namespace Business.Abstract
{
    /// <summary>
    /// OperationType service.
    /// </summary>
    public interface IOperationTypeService
    {
        /// <summary>
        /// Get all operation types.
        /// </summary>
        Task<IEnumerable<OperationTypeVM>> GetAll();

        /// <summary>
        /// Get operation type by id.
        /// </summary>
        /// <param name="id">OperationType's id.</param>
        Task<OperationTypeVM> GetById(short id);

        /// <summary>
        /// Create operationType.
        /// </summary>
        /// <param name="operationTypeVM">Includes operationType's values.</param>
        Task Create(OperationTypeVM operationTypeVM);

        /// <summary>
        /// Update operationType.
        /// </summary>
        /// <param name="operationTypeVM">Includes operationType's values.</param>
        Task Update(OperationTypeVM operationTypeVM);

        /// <summary>
        /// Delete operationType.
        /// </summary>
        /// <param name="id">OperationType's id</param>
        Task Delete(int id);
    }
}

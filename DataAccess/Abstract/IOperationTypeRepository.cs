using Model;

namespace DataAccess.Abstract
{
    /// <summary>
    /// Includes opeartions signatures.
    /// </summary>
    public interface IOperationTypeRepository
    {
        /// <summary>
        /// Get all operation types.
        /// </summary>
        IEnumerable<OperationTypeVM> GetAll();

        /// <summary>
        /// Get operation type by id.
        /// </summary>
        /// <param name="id">OperationType's id.</param>
        OperationTypeVM GetById(short id);

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

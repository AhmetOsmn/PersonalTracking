using Entity.Base;

namespace Entity
{
    /// <summary>
    /// RoleOperationType entity.
    /// </summary>
    public class RoleOperationType : BaseEntity, IEntity
    {
        /// <summary>
        /// Role id.
        /// </summary>
        public short RoleId { get; set; }

        /// <summary>
        /// Operation type id.
        /// </summary>
        public short OperationTypeId { get; set; }
    }
}

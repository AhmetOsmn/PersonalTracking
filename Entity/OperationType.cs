using Entity.Base;

namespace Entity
{
    /// <summary>
    /// Operation type entity.
    /// </summary>
    public class OperationType : BaseEntity, IEntity
    {
        /// <summary>
        /// Operation type name.
        /// </summary>
        public string Name { get; set; }
    }
}

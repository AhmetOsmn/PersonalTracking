using Entity.Base;

namespace Entity
{
    /// <summary>
    /// UserRole entity.
    /// </summary>
    public class UserRole : BaseEntity, IEntity
    {
        /// <summary>
        /// User id.
        /// </summary>
        public short UserId { get; set; }

        /// <summary>
        /// Role id.
        /// </summary>
        public short RoleId { get; set; }
    }
}

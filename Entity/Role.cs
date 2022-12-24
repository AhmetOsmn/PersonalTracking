using Entity.Base;

namespace Entity
{
    /// <summary>
    /// Role entity.
    /// </summary>
    public class Role : BaseEntity, IEntity
    {
        /// <summary>
        /// Role name.
        /// </summary>
        public string Name { get; set; }
    }
}

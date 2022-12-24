using Entity.Base;

namespace Entity
{
    /// <summary>
    /// User entity.
    /// </summary>
    public class User : BaseEntity, IEntity
    {
        /// <summary>
        /// User's name.
        /// </summary>
        public string Name { get; set; }

        /// <summary>
        /// User's surname.
        /// </summary>
        public string Surname { get; set; }

        /// <summary>
        /// User's age.
        /// </summary>
        public short Age { get; set; }
    }
}

namespace Entity.Base
{
    /// <summary>
    /// Base entity for other entities to use.
    /// </summary>
    public class BaseEntity
    {
        /// <summary>
        /// Entity id.
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Entity created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Entity modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}

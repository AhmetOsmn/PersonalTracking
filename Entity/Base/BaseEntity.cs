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
        /// Creator's id.
        /// </summary>
        public short CreatedById { get; set; }

        /// <summary>
        /// Entity modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Modifier's id.
        /// </summary>
        public short ModifiedById { get; set; }

        /// <summary>
        /// Deleted date.
        /// </summary>
        public DateTime DeletedDate { get; set; }

        /// <summary>
        /// Deleter's id.
        /// </summary>
        public short DeletedById { get; set; }
    }
}

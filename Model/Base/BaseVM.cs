namespace Model.Base
{
    /// <summary>
    /// Base view model for other view models to use.
    /// </summary>
    public class BaseVM
    {
        /// <summary>
        /// Id.
        /// </summary>
        public short Id { get; set; }

        /// <summary>
        /// Model created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Creator's id.
        /// </summary>
        public string? Creator { get; set; }
        
        /// <summary>
        /// Creator's id.
        /// </summary>
        public short CreatedById { get; set; }

        /// <summary>
        /// Model modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }

        /// <summary>
        /// Modifier's id.
        /// </summary>
        public string? Modifier { get; set; }

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
        public string? Deleter { get; set; }

        /// <summary>
        /// Deleter's id.
        /// </summary>
        public short DeletedById { get; set; }
    }
}

namespace Model.Base
{
    /// <summary>
    /// Base view model for other view models to use.
    /// </summary>
    public class BaseVM
    {
        /// <summary>
        /// Model created date.
        /// </summary>
        public DateTime CreatedDate { get; set; }

        /// <summary>
        /// Model modified date.
        /// </summary>
        public DateTime ModifiedDate { get; set; }
    }
}

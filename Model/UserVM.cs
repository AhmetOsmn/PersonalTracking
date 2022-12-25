using Model.Base;

namespace Model
{
    /// <summary>
    /// User view model.
    /// </summary>
    public class UserVM : BaseVM
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

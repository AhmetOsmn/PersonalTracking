using Model.Base;

namespace Model
{
    /// <summary>
    /// UserRole view model.
    /// </summary>
    public class UserRoleVM : BaseVM
    {
        /// <summary>
        /// User name.
        /// </summary>
        public string UserName { get; set; }

        /// <summary>
        /// Role name.
        /// </summary>
        public string RoleName { get; set; }
    }
}

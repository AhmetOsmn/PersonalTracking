using Model.Base;

namespace Model
{
    /// <summary>
    /// RoleOperationType view model.
    /// </summary>
    public class RoleOperationTypeVM : BaseVM
    {
        /// <summary>
        /// Role name.
        /// </summary>
        public string RoleName { get; set; }

        /// <summary>
        /// Operation type name.
        /// </summary>
        public string OperationTypeName { get; set; }
    }
}

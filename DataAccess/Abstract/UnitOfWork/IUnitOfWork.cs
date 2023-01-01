namespace DataAccess.Abstract.UnitOfWork
{
    public interface IUnitOfWork : IDisposable
    {
        IOperationTypeRepository OperationTypeRepository { get; }  
        IRoleOperationTypeRepository RoleOperationTypeRepository { get; }
        IRoleRepository RoleRepository { get; }
        IUserRepository UserRepository { get; }
        IUserRoleRepository UserRoleRepository { get; }
        IAccountRepository AccountRepository { get; }

        void OpenConnection();
        void CloseConnection();
        void BeginTransaction();   
        void CommitTransaction();   
        void RollbackTransaction();
    }
}

using DataAccess.Abstract;
using DataAccess.Abstract.UnitOfWork;
using System.Data;

namespace DataAccess.Concrete.UnitOfWork
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly IDbConnection _connection;
        private IDbTransaction? _transaction;

        public UnitOfWork(IDbConnection connection)
        {
            _connection = connection;
        }

        public IOperationTypeRepository OperationTypeRepository => new OperationTypeRepository(_connection, _transaction);

        public IRoleOperationTypeRepository RoleOperationTypeRepository => new RoleOperationTypeRepository(_connection, _transaction);

        public IRoleRepository RoleRepository => new RoleRepository(_connection, _transaction);

        public IUserRepository UserRepository => new UserRepository(_connection, _transaction);

        public IUserRoleRepository UserRoleRepository => new UserRoleRepository(_connection, _transaction);
        public IAccountRepository AccountRepository=> new AccountRepository(_connection, _transaction);

        public void OpenConnection()
        {
            if(_connection.State == ConnectionState.Closed)
            {                
                _connection.Open();
            }
        }

        public void CloseConnection()
        {
            if (_connection.State != ConnectionState.Closed)
            {
                _connection.Close();
            }
        }

        public void BeginTransaction()
        {
            try
            {
                _transaction = _connection.BeginTransaction();
            }
            catch (Exception exception)
            {
                // todo: logger should be added.
                throw;
            }
        }

        public void CommitTransaction()
        {
            try
            {
                _transaction?.Commit();
            }
            catch (Exception exception)
            {
                // todo: logger should be added.
                throw;
            }
        }

        public void RollbackTransaction()
        {
            try
            {
                _transaction?.Rollback();
            }
            catch (Exception exception)
            {
                // todo: logger should be added.
                throw;
            }
        }

        public void Dispose()
        {
            _transaction?.Dispose();
            _connection?.Dispose();
        }
    }
}

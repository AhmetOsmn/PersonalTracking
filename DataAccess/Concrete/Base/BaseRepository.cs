using System.Data;

namespace DataAccess.Concrete.Base
{
    public class BaseRepository
    {
        protected readonly IDbConnection Connection;
        protected readonly IDbTransaction? Transaction;

        public BaseRepository(IDbConnection connection, IDbTransaction transaction)
        {
            Connection = connection;
            Transaction = transaction;
        }
    }
}

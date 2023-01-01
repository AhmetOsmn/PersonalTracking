using Core.Extensions;
using DataAccess.Abstract.UnitOfWork;
using System.Data.SqlClient;

namespace DataAccess.Concrete.UnitOfWork
{
    public class UnitOfWorkFactory : IUnitOfWorkFactory
    {
        // TODO: Logger should be added.

        public IUnitOfWork Create()
        {            
            return new UnitOfWork(new SqlConnection(ConfigurationExtension.GetConnectionString()));
        }
    }
}

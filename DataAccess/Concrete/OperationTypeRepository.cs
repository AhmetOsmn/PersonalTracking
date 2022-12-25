using DataAccess.Abstract;
using DataAccess.Concrete.Base;
using Model;
using System.Data;

namespace DataAccess.Concrete
{
    public class OperationTypeRepository : BaseRepository,IOperationTypeRepository
    {
        public OperationTypeRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task Create(OperationTypeVM operationTypeVM)
        {
            throw new NotImplementedException();
        }
        public async Task Update(OperationTypeVM operationTypeVM)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<OperationTypeVM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<OperationTypeVM> GetById(short id)
        {
            throw new NotImplementedException();
        }     
    }
}

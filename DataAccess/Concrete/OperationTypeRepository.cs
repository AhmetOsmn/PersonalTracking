using DataAccess.Abstract;
using Model;

namespace DataAccess.Concrete
{
    public class OperationTypeRepository : IOperationTypeRepository
    {
        public Task Create(OperationTypeVM operationTypeVM)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<OperationTypeVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public OperationTypeVM GetById(short id)
        {
            throw new NotImplementedException();
        }

        public Task Update(OperationTypeVM operationTypeVM)
        {
            throw new NotImplementedException();
        }
    }
}

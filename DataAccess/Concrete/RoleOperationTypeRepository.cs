using DataAccess.Abstract;
using DataAccess.Concrete.Base;
using Model;
using System.Data;

namespace DataAccess.Concrete
{
    public class RoleOperationTypeRepository :BaseRepository, IRoleOperationTypeRepository
    {
        public RoleOperationTypeRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task Create(RoleOperationTypeVM roleOperationTypeVM)
        {
            throw new NotImplementedException();
        }
        public async Task Update(RoleOperationTypeVM roleOperationTypeVM)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoleOperationTypeVM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<RoleOperationTypeVM> GetById(short id)
        {
            throw new NotImplementedException();
        }
    }
}

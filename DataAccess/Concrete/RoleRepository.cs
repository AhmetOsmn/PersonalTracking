using DataAccess.Abstract;
using DataAccess.Concrete.Base;
using Model;
using System.Data;

namespace DataAccess.Concrete
{
    public class RoleRepository : BaseRepository, IRoleRepository
    {
        public RoleRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task Create(RoleVM roleVM)
        {
            throw new NotImplementedException();
        }
        public async Task Update(RoleVM roleVM)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<RoleVM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<RoleVM> GetById(short id)
        {
            throw new NotImplementedException();
        }       
    }
}

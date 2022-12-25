using DataAccess.Abstract;
using DataAccess.Concrete.Base;
using Model;
using System.Data;

namespace DataAccess.Concrete
{
    public class UserRoleRepository : BaseRepository, IUserRoleRepository
    {
        public UserRoleRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task Create(UserRoleVM userRoleVM)
        {
            throw new NotImplementedException();
        }
        public async Task Update(UserRoleVM userRoleVM)
        {
            throw new NotImplementedException();
        }

        public async Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<UserRoleVM>> GetAll()
        {
            throw new NotImplementedException();
        }

        public async Task<UserRoleVM> GetById(short id)
        {
            throw new NotImplementedException();
        }     
    }
}

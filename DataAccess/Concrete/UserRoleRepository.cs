using DataAccess.Abstract;
using Model;

namespace DataAccess.Concrete
{
    public class UserRoleRepository : IUserRoleRepository
    {
        public Task Create(UserRoleVM userRoleVM)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserRoleVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserRoleVM GetById(short id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserRoleVM userRoleVM)
        {
            throw new NotImplementedException();
        }
    }
}

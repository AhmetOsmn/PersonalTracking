using DataAccess.Abstract;
using Model;

namespace DataAccess.Concrete
{
    public class RoleRepository : IRoleRepository
    {
        public Task Create(RoleVM roleVM)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<RoleVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public RoleVM GetById(short id)
        {
            throw new NotImplementedException();
        }

        public Task Update(RoleVM roleVM)
        {
            throw new NotImplementedException();
        }
    }
}

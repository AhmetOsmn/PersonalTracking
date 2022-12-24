using DataAccess.Abstract;
using Model;

namespace DataAccess.Concrete
{
    public class UserRepository : IUserRepository
    {
        public Task Create(UserVM userVM)
        {
            throw new NotImplementedException();
        }

        public Task Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<UserVM> GetAll()
        {
            throw new NotImplementedException();
        }

        public UserVM GetById(short id)
        {
            throw new NotImplementedException();
        }

        public Task Update(UserVM userVM)
        {
            throw new NotImplementedException();
        }
    }
}

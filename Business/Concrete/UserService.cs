using Business.Abstract;
using DataAccess.Abstract.UnitOfWork;
using Model;

namespace Business.Concrete
{
    public class UserService : IUserService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public UserService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Create(UserVM userVM)
        {
            if(userVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.UserRepository.Create(userVM);

            unitOfWork.CloseConnection();
        }

        public async Task Update(UserVM userVM)
        {
            if (userVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.UserRepository.Update(userVM);

            unitOfWork.CloseConnection();
        }

        public async Task Delete(UserVM userVM)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.UserRepository.Delete(userVM);

            unitOfWork.CloseConnection();
        }

        public async Task<IEnumerable<UserVM>> GetAll()
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var users = await unitOfWork.UserRepository.GetAll();

            unitOfWork.CloseConnection();

            return users;
        }

        public async Task<UserVM> GetById(short id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var user =  await unitOfWork.UserRepository.GetById(id);

            unitOfWork.CloseConnection();

            return user;
        }
    }
}

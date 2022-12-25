using Business.Abstract;
using DataAccess.Abstract.UnitOfWork;
using Model;

namespace Business.Concrete
{
    public class UserRoleService : IUserRoleService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public UserRoleService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Create(UserRoleVM userRoleVM)
        {
            if(userRoleVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.UserRoleRepository.Create(userRoleVM);

            unitOfWork.CloseConnection();
        }

        public async Task Update(UserRoleVM userRoleVM)
        {
            if (userRoleVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.UserRoleRepository.Update(userRoleVM);

            unitOfWork.CloseConnection();
        }

        public async Task Delete(int id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.UserRoleRepository.Delete(id);

            unitOfWork.CloseConnection();
        }

        public async Task<IEnumerable<UserRoleVM>> GetAll()
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var userRoles = await unitOfWork.UserRoleRepository.GetAll();

            unitOfWork.CloseConnection();

            return userRoles;
        }

        public async Task<UserRoleVM> GetById(short id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var userRole = await unitOfWork.UserRoleRepository.GetById(id);

            unitOfWork.CloseConnection();

            return userRole;
        }   
    }
}

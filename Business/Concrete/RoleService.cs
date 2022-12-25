using Business.Abstract;
using DataAccess.Abstract.UnitOfWork;
using DataAccess.Concrete.UnitOfWork;
using Model;

namespace Business.Concrete
{
    public class RoleService : IRoleService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public RoleService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Create(RoleVM roleVM)
        {
            if (roleVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.RoleRepository.Create(roleVM);

            unitOfWork.CloseConnection();
        }

        public async Task Update(RoleVM roleVM)
        {
            if (roleVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.RoleRepository.Update(roleVM);

            unitOfWork.CloseConnection();
        }


        public async Task Delete(int id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.RoleRepository.Delete(id);

            unitOfWork.CloseConnection();
        }

        public async Task<IEnumerable<RoleVM>> GetAll()
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var roles = await unitOfWork.RoleRepository.GetAll();

            unitOfWork.CloseConnection();

            return roles;
        }

        public async Task<RoleVM> GetById(short id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var role = await unitOfWork.RoleRepository.GetById(id);

            unitOfWork.CloseConnection();

            return role;
        }
    }
}

using Business.Abstract;
using DataAccess.Abstract.UnitOfWork;
using Model;

namespace Business.Concrete
{
    public class RoleOperationTypeService : IRoleOperationTypeService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public RoleOperationTypeService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Create(RoleOperationTypeVM roleOperationTypeVM)
        {
            if (roleOperationTypeVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.RoleOperationTypeRepository.Create(roleOperationTypeVM);

            unitOfWork.CloseConnection();
        }

        public async Task Update(RoleOperationTypeVM roleOperationTypeVM)
        {
            if (roleOperationTypeVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.RoleOperationTypeRepository.Update(roleOperationTypeVM);

            unitOfWork.CloseConnection();
        }

        public async Task Delete(int id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.RoleOperationTypeRepository.Delete(id);

            unitOfWork.CloseConnection();
        }

        public async Task<IEnumerable<RoleOperationTypeVM>> GetAll()
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var roleOperationTypes = await unitOfWork.RoleOperationTypeRepository.GetAll();

            unitOfWork.CloseConnection();

            return roleOperationTypes;
        }

        public async Task<RoleOperationTypeVM> GetById(short id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var roleOperationType = await unitOfWork.RoleOperationTypeRepository.GetById(id);

            unitOfWork.CloseConnection();

            return roleOperationType;
        }
    }
}

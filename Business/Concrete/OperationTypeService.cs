using Business.Abstract;
using DataAccess.Abstract.UnitOfWork;
using Model;

namespace Business.Concrete
{
    public class OperationTypeService : IOperationTypeService
    {
        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public OperationTypeService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task Create(OperationTypeVM operationTypeVM)
        {
            if (operationTypeVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.OperationTypeRepository.Create(operationTypeVM);

            unitOfWork.CloseConnection();
        }

        public async Task Update(OperationTypeVM operationTypeVM)
        {
            if (operationTypeVM == null)
            {
                return;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.OperationTypeRepository.Update(operationTypeVM);

            unitOfWork.CloseConnection();
        }

        public async Task Delete(int id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            await unitOfWork.OperationTypeRepository.Delete(id);

            unitOfWork.CloseConnection();
        }

        public async Task<IEnumerable<OperationTypeVM>> GetAll()
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var operationTypes = await unitOfWork.OperationTypeRepository.GetAll();

            unitOfWork.CloseConnection();

            return operationTypes;
        }

        public async Task<OperationTypeVM> GetById(short id)
        {
            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var operationType = await unitOfWork.OperationTypeRepository.GetById(id);

            unitOfWork.CloseConnection();

            return operationType;
        }
    }
}

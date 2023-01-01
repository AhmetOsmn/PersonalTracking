using Business.Abstract;
using DataAccess.Abstract.UnitOfWork;
using Model.Account;

namespace Business.Concrete
{
    public class AccountService : IAccountService
    {

        private readonly IUnitOfWorkFactory _unitOfWorkFactory;

        public AccountService(IUnitOfWorkFactory unitOfWorkFactory)
        {
            _unitOfWorkFactory = unitOfWorkFactory;
        }

        public async Task<string?> Login(LoginVM loginVM)
        {
            if(loginVM == null)
            {
                return null;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var result = await unitOfWork.AccountRepository.Login(loginVM);

            unitOfWork.CloseConnection();

            return result;
        }

        public async Task<string?> Register(RegisterVM registerVM)
        {
            if (registerVM == null)
            {
                return null;
            }

            using var unitOfWork = _unitOfWorkFactory.Create();

            unitOfWork.OpenConnection();

            var result = await unitOfWork.AccountRepository.Register(registerVM);

            unitOfWork.CloseConnection();

            return result;
        }
    }
}

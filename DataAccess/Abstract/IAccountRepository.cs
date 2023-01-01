using Model.Account;

namespace DataAccess.Abstract
{
    public interface IAccountRepository
    {
        Task<string?> Register(RegisterVM registerVM);
        Task<string?> Login(LoginVM loginVM);
    }
}

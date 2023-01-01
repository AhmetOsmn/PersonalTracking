using Model.Account;

namespace Business.Abstract
{
    public interface IAccountService
    {
        Task<string?> Register(RegisterVM registerVM);
        Task<string?> Login(LoginVM loginVM);
    }
}

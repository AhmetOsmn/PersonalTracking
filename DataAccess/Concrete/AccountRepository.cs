using Dapper;
using DataAccess.Abstract;
using DataAccess.Concrete.Base;
using Entity;
using Model.Account;
using System.Data;

namespace DataAccess.Concrete
{
    public class AccountRepository : BaseRepository, IAccountRepository
    {
        public AccountRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task<string?> Login(LoginVM loginVM)
        {
            string query =
            @$"
                SELECT [Username] FROM [dbo].[User]
                WHERE [IsActive] = 1 AND [Username] = @Username AND [Password] = @Password   
            ";

            return await Connection.QueryFirstOrDefaultAsync<string>(query, loginVM, transaction: Transaction);
        }

        public async Task<string?> Register(RegisterVM registerVM)
        {
            if (await IsUsernameExistsAsync(registerVM.Username))
            {
                return "exists";
            }

            string query =
            @$"
                INSERT INTO [dbo].[User]
                (
                    [Name],
                    [Surname],
                    [Age],           
                    [Username],                
                    [Password]         
                )
                VALUES
                (
                    @Name,
                    @Surname,
                    @Age,
                    @Username,
                    @Password
                )            
            ";

            var result = await Connection.ExecuteAsync(query, registerVM, transaction: Transaction);

            return result >= 1 ? registerVM.Username : null;
        }

        private async Task<bool> IsUsernameExistsAsync(string username)
        {
            var myParamteter = new { Username = username };

            string query =
            @$"
            SELECT [Username] FROM [dbo].[User]
            WHERE [IsActive] = 1 AND [Username] = @Username  
            ";

            var result = await Connection.QueryFirstOrDefaultAsync<string>(query, myParamteter, transaction: Transaction);

            return result == null ? false : true;
        }
    }
}

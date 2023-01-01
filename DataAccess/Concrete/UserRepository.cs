using Dapper;
using DataAccess.Abstract;
using DataAccess.Concrete.Base;
using Model;
using Model.Create;
using System.Data;

namespace DataAccess.Concrete
{
    public class UserRepository : BaseRepository, IUserRepository
    {
        public UserRepository(IDbConnection connection, IDbTransaction transaction) : base(connection, transaction)
        {
        }

        public async Task Create(UserCreateVM userCreateVM)
        {
            string query = 
            @$"
                INSERT INTO [dbo].[User]
                (
                    [Name]
                    [Surname],
                    [Age],                
                    [CreatedById]         
                )
                VALUES
                (
                    @Name,
                    @Surname,
                    @Age,
                    @CreatedById               
                )
            ";

            await Connection.ExecuteAsync(query, userCreateVM, transaction: Transaction);
        }

        public async Task Update(UserVM userVM)
        {
            string query = 
            @$"
                UPDATE [dbo].[User]
                SET
                [Name] = @Name
                [Surname] = @Surname,
                [Age] = @Age,               
                [CreatedDate] =  @CreatedDate,              
                [CreatedById] =  @CreatedById,              
                [ModifiedDate] = @ModifiedDate,   
                [ModifiedById] = @ModifiedById,             
                [DeletedDate] =  @DeletedDate,   
                [DeletedById] =  @DeletedById
                WHERE [Id] = @Id AND IsActive = 1
            ";

            await Connection.ExecuteAsync(query, userVM, transaction: Transaction);
        }

        public async Task Delete(UserVM userVM)
        {
            string query = 
            @$"
                UPDATE [dbo].[User]
                SET
                [IsActive] = 0,           
                [DeletedDate] =  @DeletedDate,   
                [DeletedById] =  @DeletedById
                WHERE [Id] = @Id AND IsActive = 1                
            ";

            await Connection.ExecuteAsync(query, userVM, transaction: Transaction);
        }

        public async Task<IEnumerable<UserVM>> GetAll()
        {
            string query = 
            @$"
                SELECT 
                    U.[Id],
                    U.[Name],
                    U.[Surname],
                    U.[CreatedDate],
                    C.[Name] + C.[Surname] AS 'Creator',
                    U.[ModifiedDate],
                    M.[Name] + C.[Surname] AS 'Modifier',
                    U.[DeletedDate],
                    D.[Name] + C.[Surname] AS 'Deleter',
                FROM [dbo].[User] AS U 
                LEFT JOIN [dbo].[User] C US ON U.[Id] = C.[Id] AND C.[IsActive] = 1
                LEFT JOIN [dbo].[User] M US ON U.[Id] = M.[Id] AND M.[IsActive] = 1
                LEFT JOIN [dbo].[User] D US ON U.[Id] = D.[Id] AND D.[IsActive] = 1
                WHERE U.[IsActive] = 1
            ";

            return await Connection.QueryAsync<UserVM>(query, transaction: Transaction);
        }

        public async Task<UserVM> GetById(short id)
        {
            string query = 
            @$"
                SELECT 
                    U.[Id],
                    U.[Name],
                    U.[Surname],
                    U.[CreatedDate],
                    C.[Name] + C.[Surname] AS 'Creator',
                    U.[ModifiedDate],
                    M.[Name] + C.[Surname] AS 'Modifier',
                    U.[DeletedDate],
                    D.[Name] + C.[Surname] AS 'Deleter',
                FROM [dbo].[User] AS U 
                LEFT JOIN [dbo].[User] C US ON U.[Id] = C.[Id] AND C.[IsActive] = 1
                LEFT JOIN [dbo].[User] M US ON U.[Id] = M.[Id] AND M.[IsActive] = 1
                LEFT JOIN [dbo].[User] D US ON U.[Id] = D.[Id] AND D.[IsActive] = 1
                WHERE U.[IsActive] = 1 AND U.[Id] = @Id
            ";

            return await Connection.QueryFirstOrDefaultAsync<UserVM>(query, transaction: Transaction);
        }
    }
}

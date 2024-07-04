using AquarioMania.DataContext;
using AquarioMania.Models;
using AquarioMania.Models.User;
using Azure;
using Dapper;
using Microsoft.AspNetCore.Http.HttpResults;
using System.Text.Json.Serialization;

namespace AquarioMania.Repository;

public class UserRepository : IUserRepository
{
    private readonly DapperContext _context;
    public UserRepository(DapperContext context)
    {
        _context = context;
    }
    public async Task<UserResponseModel> CreateUser(UserModel user)
    {
        try
        {
            var query = @$"INSERT INTO Users (
                name,
                email,
                password,
                city,
                state,
                country,
                profile_id,
                created_at,
                updated_at
            ) OUTPUT INSERTED.* VALUES (
                '{user.Name}',
                '{user.Email}',
                '{user.Password}',   
                '{user.City}',
                '{user.State}',
                '{user.Country}',
                '{user.Profile_id}',
                '{user.Created_at}',
                '{user.Updated_at}'
            );";

            using(var connection = _context.CreateConnection())
            {
                var response = await connection.QuerySingleOrDefaultAsync<UserResponseModel>(query);
                return response;
            }
        }
        catch (Exception ex)
        {

            throw new Exception($"Exception while creating user! {ex}"); ;
        }
    }

    public async Task<UserResponseModel> DeleteUser(int id)
    {
        try
        {
            var query = @$"DELETE FROM Users OUTPUT DELETED.* WHERE id = '{id}'";

            using (var connection = _context.CreateConnection())
            {
                var response = await connection.QueryFirstOrDefaultAsync<UserResponseModel>(query);
                return response;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while deleting user! {ex}");
        }
    }

    public async Task<UserResponseModel> GetUserByEmail(string email)
    {
        try
        {
            var query = @$"SELECT u.*, p.profile Profile_name FROM Users u JOIN Profile p ON p.id = u.profile_id WHERE u.email = '{email}'";

            using (var connection = _context.CreateConnection())
            {
                var response = await connection.QueryFirstOrDefaultAsync<UserResponseModel>(query);
                return response;
            }
        }
        catch (Exception ex)
        {

            throw new Exception($"Exception while retrieving user! {ex}");
        }
    }

    public async Task<UserResponseModel> GetUserById(int id)
    {
        try
        {
            var query = @$"SELECT u.*, p.profile Profile_name FROM Users u JOIN Profile p ON p.id = u.profile_id WHERE u.id = '{id}'";

            using(var connection = _context.CreateConnection())
            {
                var response = await connection.QueryFirstOrDefaultAsync<UserResponseModel>(query);
                return response;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while retrieving user! {ex}");
        }
    }

    public async Task<IEnumerable<UserResponseModel>> GetUsers()
    {
        try
        {
            var query = @"SELECT u.*, p.profile Profile_name FROM Users u JOIN Profile p ON p.id = u.profile_id";

            using (var connection = _context.CreateConnection())
            {
                var response = await connection.QueryAsync<UserResponseModel>(query);

                response.Select(x => new UserResponseModel()
                {
                    Id = x.Id,
                    Email = x.Email,
                    City = x.City,
                    State = x.State,
                    Country = x.Country,
                    Profile_id = x.Profile_id,
                    Profile_name = x.Profile_name,
                    Created_at = x.Created_at,
                    Updated_at = x.Updated_at,
                }).ToList();

                return response;
            }
        }
        catch (Exception ex)
        {

            throw new Exception($"Exception while retrieving users! {ex}");
        }
    }

    public async Task<UserResponseModel> UpdateUser(UserUpdateModel user)
    {
        try
        {
            var query = @$"UPDATE Users SET 
                                name = '{user.Name}'
                                ,city = '{user.City}'
                                ,state = '{user.State}'
                                ,country = '{user.Country}'
                                ,updated_at = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}'
                                OUTPUT inserted.*
                                WHERE id = '{user.Id}'";

            using (var connection = _context.CreateConnection())
            {
                var response = await connection.QuerySingleOrDefaultAsync<UserResponseModel>(query);
                return response;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while updating users! {ex}"); ;
        }
    }

    public async Task<UserResponseModel> UpdatePassword(UserChangePasswordModel changePassword)
    {
        try
        {
            var query = @$"UPDATE Users SET 
                                password = '{changePassword.Password}'
                                ,updated_at = '{DateTime.Now:yyyy-MM-dd HH:mm:ss}'
                                OUTPUT inserted.*
                                WHERE id = '{changePassword.Id}'";

            using (var connection = _context.CreateConnection())
            {
                var response = await connection.QuerySingleOrDefaultAsync<UserResponseModel>(query);
                return response;
            }
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while updating password! {ex}"); ;
        }
    }
}

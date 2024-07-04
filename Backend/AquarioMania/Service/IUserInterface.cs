using AquarioMania.Models.User;

namespace AquarioMania.Service;

public interface IUserInterface
{
    Task<IEnumerable<UserResponseModel>> GetUsers();
    Task<UserResponseModel> CreateUser(UserModel user);
    Task<UserResponseModel> GetUserById(int id);
    Task<UserResponseModel> GetUserByEmail(string email);
    Task<UserResponseModel> UpdateUser(UserUpdateModel user);
    Task<UserResponseModel> DeleteUser(int id);
    Task<UserResponseModel> UpdatePassword(UserChangePasswordModel changePassowrd);

}

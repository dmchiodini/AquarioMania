using AquarioMania.Models;
using AquarioMania.Models.User;

namespace AquarioMania.Service;

public interface IUserInterface
{
    Task<ServiceResponse<IEnumerable<UserResponseModel>>> GetUsers();
    Task<ServiceResponse<UserResponseModel>> CreateUser(UserModel user);
    Task<ServiceResponse<UserResponseModel>> GetUserById(int id);
    Task<ServiceResponse<UserResponseModel>> GetUserByEmail(string email);
    Task<ServiceResponse<UserResponseModel>> UpdateUser(UserUpdateModel user);
    Task<ServiceResponse<UserResponseModel>> DeleteUser(int id);
    Task<ServiceResponse<UserResponseModel>> UpdatePassword(UserChangePasswordModel changePassowrd);

}

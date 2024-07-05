using AquarioMania.Models.User;
using AquarioMania.Repository;
using AquarioMania.Utils;

namespace AquarioMania.Service;

public class UserService : IUserInterface
{
    private readonly IUserRepository _userRepository;
    private readonly SystemUtils _utils = new SystemUtils();
    private readonly AquarioManiaSettings _settings;

    public UserService(IUserRepository userRepository, AquarioManiaSettings settings)
    {
        _userRepository = userRepository;
        _settings = settings;
    }

    public Task<UserResponseModel> CreateUser(UserModel user)
    {
        try
        {
            user.Password = _utils.HashPassword(user.Password);

            var createdUser = _userRepository.CreateUser(user);
            return createdUser;
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while creating user! {ex}");
        }
    }

    public Task<UserResponseModel> DeleteUser(int id)
    {
        try
        {
            var deleteUser = _userRepository.DeleteUser(id);
            return deleteUser;
        }
        catch (Exception ex)
        { 
            throw new Exception($"Exception while retrieving users! {ex}");
        }
    }

    public async Task<UserResponseModel> GetUserByEmail(string email)
    {
        try
        {
            var user = await _userRepository.GetUserByEmail(email);
            return user;
        }
        catch (Exception ex)
        {

            throw new Exception($"Exception while retrieving users! {ex}");
        }
    }

    public async Task<UserResponseModel> GetUserById(int id)
    {
        try
        {
            var user = await _userRepository.GetUserById(id);
            return user;
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while retrieving users! {ex}");
        }
    }

    public async Task<IEnumerable<UserResponseModel>> GetUsers()
    {
        try
        {
            var listUser = await _userRepository.GetUsers();
            return listUser;
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
            var updatedUser = await _userRepository.UpdateUser(user);
            return updatedUser;
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while updating users! {ex}");
        }
    }

    public async Task<UserResponseModel> UpdatePassword(UserChangePasswordModel changePassword)
    {
        try
        {
            changePassword.Password = _utils.HashPassword(changePassword.Password);

            var updatedPassword = await _userRepository.UpdatePassword(changePassword);
            return updatedPassword;
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while updating users! {ex}");
        }
    }
}
using AquarioMania.Models;
using AquarioMania.Models.LivingBeing;
using AquarioMania.Models.User;
using AquarioMania.Repository;
using AquarioMania.Utils;
using Azure;
using static System.Runtime.InteropServices.JavaScript.JSType;

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

    public async Task<ServiceResponse<UserResponseModel>> CreateUser(UserModel user)
    {
        try
        {
            user.Password = _utils.HashPassword(user.Password);

            var response = await _userRepository.CreateUser(user);

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status201Created,
                Success = true,
                Message = "Usuário criado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<UserResponseModel>() 
            { 
                Status = StatusCodes.Status500InternalServerError, 
                Success = false, 
                Message =$"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<UserResponseModel>> DeleteUser(int id)
    {
        try
        {
            var response = await _userRepository.DeleteUser(id);

            if (response == null)
            {
                return new ServiceResponse<UserResponseModel>()
                {
                    Status = StatusCodes.Status404NotFound,
                    Success = false,
                    Message = $"Não foi encontrado usuário com o id '{id}'",
                    Data = null
                };
            }

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuário deletado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<UserResponseModel>> GetUserByEmail(string email)
    {
        try
        {
            var response = await _userRepository.GetUserByEmail(email);

            if (response == null)
            {
                return new ServiceResponse<UserResponseModel>()
                {
                    Status = StatusCodes.Status404NotFound,
                    Success = false,
                    Message = $"Não foi encontrado usuário com o email '{email}'",
                    Data = null
                };
            }

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuários retornado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<UserResponseModel>> GetUserById(int id)
    {
        try
        {
            var response = await _userRepository.GetUserById(id);
            if (response == null)
            {
                return new ServiceResponse<UserResponseModel>()
                {
                    Status = StatusCodes.Status404NotFound,
                    Success = false,
                    Message = $"Não foi encontrado usuário com o id '{id}'",
                    Data = null
                };
            }

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuário retornado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<IEnumerable<UserResponseModel>>> GetUsers()
    {
        try
        {
            var response = await _userRepository.GetUsers();

            if (response == null)
            {
                return new ServiceResponse<IEnumerable<UserResponseModel>>()
                {
                    Status = StatusCodes.Status204NoContent,
                    Success = false,
                    Message = "Não há usuários cadastrados!",
                    Data = null
                };
            }

            return new ServiceResponse<IEnumerable<UserResponseModel>>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuários retornados com sucesso",
                Data = response
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<IEnumerable<UserResponseModel>>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<UserResponseModel>> UpdateUser(UserUpdateModel user)
    {
        try
        {
            var response = await _userRepository.UpdateUser(user);

            if (response == null)
            {
                return new ServiceResponse<UserResponseModel>()
                {
                    Status = StatusCodes.Status404NotFound,
                    Success = false,
                    Message = $"Não foi encontrado usuário com o id '{user.Id}'",
                    Data = null
                };
            }

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuário atualizado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<UserResponseModel>> UpdatePassword(UserChangePasswordModel changePassword)
    {
        try
        {
            changePassword.Password = _utils.HashPassword(changePassword.Password);

            var response = await _userRepository.UpdatePassword(changePassword);

            if (response == null)
            {
                return new ServiceResponse<UserResponseModel>()
                {
                    Status = StatusCodes.Status404NotFound,
                    Success = false,
                    Message = $"Não foi encontrado usuário com o id '{changePassword.Id}'",
                    Data = null
                };
            }

            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuário atualizado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }
}
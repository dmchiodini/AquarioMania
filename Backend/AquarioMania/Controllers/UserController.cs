using AquarioMania.Models.User;
using AquarioMania.Models;
using AquarioMania.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Azure;

namespace AquarioMania.Controllers;

[Route("api/[controller]")]
[ApiController]
public class UserController : ControllerBase
{
    private readonly IUserInterface _service;

    public UserController(IUserInterface service)
    {
        _service = service;
    }

    [HttpGet]
    public async Task<ActionResult<ServiceResponse<IEnumerable<UserModel>>>> GetUsers()
    {
        try
        {
            var response = await _service.GetUsers();
            return StatusCode(StatusCodes.Status200OK, new ServiceResponse<IEnumerable<UserResponseModel>>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = response.Count() == 0 ? "Não há usuários cadastrados" : "Usuários retornados com sucesso",
                Data = response,
            });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserResponseModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }
    }

    [HttpGet("{id}")]
    public async Task<ActionResult<ServiceResponse<UserModel>>> GetUsers(int id)
    {
        try
        {
            var response = await _service.GetUserById(id);
            return StatusCode(StatusCodes.Status200OK, new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = response == null ? $"Não foi localizado usuário com o id {id}" : "Usuários retornado com sucesso",
                Data = response,
            });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }
    }

    [HttpGet("GetByEmail")]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> GetUserByEmail(string email)
    {
         try 

        {
            var response = await _service.GetUserByEmail(email);
            return StatusCode(StatusCodes.Status200OK, new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = response == null ? $"Não foi localizado usuário com o email {email}" : "Usuários retornado com sucesso",
                Data = response,
            });
        }
	    catch (Exception ex)
	    {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }
    
    }

    [HttpDelete]
    public async Task<ActionResult<ServiceResponse<UserModel>>> DeleteUser(int id) 
    {
        try 
	    {
            var response = await _service.DeleteUser(id);
            return StatusCode(StatusCodes.Status200OK, new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuário deletado com sucesso",
                Data = response,
            });
        }
	    catch (Exception ex)
	    {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }
    
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> CreateUser(UserModel user)
    {
        try
        {
            var response = await _service.CreateUser(user);
            return StatusCode(StatusCodes.Status201Created, new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status201Created,
                Success = true,
                Message = "Usuário criado com sucesso",
                Data = response,
            });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }

    }

    [HttpPut]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> UpdateUser(UserUpdateModel user)
    {
        try
        {
            var response = await _service.UpdateUser(user);
            return StatusCode(StatusCodes.Status200OK, new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Usuário atualizado com sucesso",
                Data = response,
            });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }

    }

    [HttpPut("UpdatedPassword")]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> UpdatePassword(UserChangePasswordModel changePassword)
    {
        try
        {
            var response = await _service.UpdatePassword(changePassword);
            return StatusCode(StatusCodes.Status200OK, new ServiceResponse<UserResponseModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Senha atualizada com sucesso",
                Data = response,
            });
        }
        catch (Exception ex)
        {
            return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<UserModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
        }

    }
}

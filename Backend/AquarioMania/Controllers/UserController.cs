using AquarioMania.Models.User;
using AquarioMania.Models;
using AquarioMania.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Azure;
using AquarioMania.Models.LivingBeing;
using Microsoft.AspNetCore.Authorization;

namespace AquarioMania.Controllers;

[Route("api/[controller]")]
[ApiController]
[Authorize]
public class UserController : ControllerBase
{
    private readonly IUserInterface _service;

    public UserController(IUserInterface service)
    {
        _service = service;
    }

    [HttpGet]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<IEnumerable<UserResponseModel>>>> GetUsers()
    {
        var response = await _service.GetUsers();
        return response;
    }

    [HttpGet("{id}")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> GetUsers(int id)
    {
        var response = await _service.GetUserById(id);
        return Ok(response);
    }

    [HttpGet("GetByEmail")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> GetUserByEmail(string email)
    {
        var response = await _service.GetUserByEmail(email);
        return response;    
    }

    [HttpDelete]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> DeleteUser(int id) 
    {
        var response = await _service.DeleteUser(id);
        return response;    
    }

    [HttpPost]
    [ProducesResponseType(StatusCodes.Status201Created)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> CreateUser(UserModel user)
    {
        var response = await _service.CreateUser(user);
        return response;
    }

    [HttpPut]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> UpdateUser(UserUpdateModel user)
    {
        var response = await _service.UpdateUser(user);
        return response;
    }

    [HttpPut("UpdatedPassword")]
    [ProducesResponseType(StatusCodes.Status200OK)]
    [ProducesResponseType(StatusCodes.Status400BadRequest)]
    [ProducesResponseType(StatusCodes.Status401Unauthorized)]
    [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
    public async Task<ActionResult<ServiceResponse<UserResponseModel>>> UpdatePassword(UserChangePasswordModel changePassword)
    {
        var response = await _service.UpdatePassword(changePassword);
        return response;

    }
}

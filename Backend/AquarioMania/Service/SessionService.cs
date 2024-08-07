﻿using AquarioMania.Models;
using AquarioMania.Models.Session;
using AquarioMania.Models.User;
using AquarioMania.Utils;
using Azure;

namespace AquarioMania.Service;

public class SessionService : ISessionInterface
{
    private readonly IUserInterface _userService;
    private readonly SystemUtils _utils = new SystemUtils();
    private readonly AquarioManiaSettings _settings;

    public SessionService(IUserInterface userService, AquarioManiaSettings settings)
    {
        _userService = userService;
        _settings = settings;
    }

    public async Task<ServiceResponse<SessionModel>> CreateSession(CreateSessionModel createSession)
    {
        try
        {
            UserResponseModel user = new UserResponseModel();

            var passwordHasher = string.Empty;

            var getUser = await _userService.GetUserByEmail(createSession.Email);

            user = getUser.Data;

            if(user == null)
            {
                return new ServiceResponse<SessionModel>()
                {
                    Status = StatusCodes.Status401Unauthorized,
                    Success = false,
                    Message = "Não há usuário cadastrado com este e-mail",
                    Data = null,
                };
            }

            passwordHasher = user.Password;

            if (!_utils.VerifyPasswordHash(createSession.Password, passwordHasher))
            {
                return new ServiceResponse<SessionModel>()
                {
                    Status = StatusCodes.Status401Unauthorized,
                    Success = false,
                    Message = "Senha incorreta",
                    Data = null,
                };
            }

            var key = _settings.PrivateKey;

            var createdSession = new SessionModel()
            {
                Token = _utils.GenerateToken(key, user.Id, user.Name, user.Email, user.Profile_id),
                Id = user.Id,
                Name = user.Name,
                Email = user.Email,
                City = user.City,
                State = user.State,  
                Country = user.Country,
                Profile_id = user.Profile_id,
                Profile_name = user.Profile_name,
            };

            return new ServiceResponse<SessionModel>()
            {
                Status = StatusCodes.Status201Created,
                Success = true,
                Message = "Login efetuado com sucesso",
                Data = createdSession,
            };


        }
        catch (Exception ex)
        {
            return new ServiceResponse<SessionModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = true,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

}

using AquarioMania.Models;
using AquarioMania.Models.LivingBeing;
using AquarioMania.Repository;
using AquarioMania.Utils;
using Azure;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AquarioMania.Service;

public class LivingBeingService : ILivingBeingInterface
{
    private readonly ILivingBeingRepository _livingBeingRepository;
    private readonly SystemUtils _utils = new SystemUtils();
    private readonly AquarioManiaSettings _settings;
    public LivingBeingService(ILivingBeingRepository livingBeingRepository, AquarioManiaSettings settings)
    {
        _livingBeingRepository = livingBeingRepository;
        _settings = settings;
    }

    public async Task<ServiceResponse<LivingBeingModel>> CreateLivingBeing(LivingBeingModel livingBeing, string token)
    {
        try
        {
            var key = _settings.PrivateKey;
            var decodeToken = _utils.GetDecodeToken(token.Split(' ')[1], key) ?? throw new Exception("ErrorDecodingToken");
            var response = await _livingBeingRepository.CreateLivingBeing(livingBeing);

            return new ServiceResponse<LivingBeingModel>()
            {
                Status = StatusCodes.Status201Created,
                Success = true,
                Message = "Ser vivo criado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<LivingBeingModel>()
            {
                Status = StatusCodes.Status201Created,
                Success = true,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<LivingBeingModel>> DeleteLivingBeing(int id)
    {
        try
        {
            var response = await _livingBeingRepository.DeleteLivingBeing(id);  

            if (response == null)
            {
                return new ServiceResponse<LivingBeingModel>() 
                { 
                    Status = StatusCodes.Status404NotFound, 
                    Success = false, 
                    Message = $"Não foi encontrado ser vivo com o id '{id}'",
                    Data= null,
                };
            }

            return new ServiceResponse<LivingBeingModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Ser vivo deletado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<LivingBeingModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<IEnumerable<ListLivingBeingModel>>> GetLivingBeing()
    {
        try
        {
            var response = await _livingBeingRepository.GetLivingBeing();
            if (response == null)
            {
                return new ServiceResponse<IEnumerable<ListLivingBeingModel>>()
                {
                    Status = StatusCodes.Status204NoContent,
                    Success = false,
                    Message = "Não há seres vivos cadastrados",
                    Data = null,
                };
            }

            return new ServiceResponse<IEnumerable<ListLivingBeingModel>>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Seres vivos retornados com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<IEnumerable<ListLivingBeingModel>>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<ListLivingBeingModel>> GetLivingBeingById(int id)
    {
        try
        {
            var response = await _livingBeingRepository.GetLivingBeingById(id);

            if (response == null)
            {
                return new ServiceResponse<ListLivingBeingModel>()
                {
                    Status = StatusCodes.Status204NoContent,
                    Success = false,
                    Message = "Não há seres vivos cadastrados",
                    Data = null,
                };
            }

            return new ServiceResponse<ListLivingBeingModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Ser vivo retornado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<ListLivingBeingModel>()
            {
                Status = StatusCodes.Status500InternalServerError,
                Success = false,
                Message = $"{ex.Message}",
                Data = null,
                Error = "InternalServerError"
            };
        }
    }

    public async Task<ServiceResponse<LivingBeingModel>> UpdateLivingBeing(LivingBeingModel livingBeing, string token)
    {
        try
        {
            var key = _settings.PrivateKey;
            var decodeToken = _utils.GetDecodeToken(token.Split(' ')[1], key) ?? throw new Exception("ErrorDecodingToken", new Exception(""));
            var response = await _livingBeingRepository.UpdateLivingBeing(livingBeing);


            if (response == null)
            {
                return new ServiceResponse<LivingBeingModel>() 
                { 
                    Status = StatusCodes.Status404NotFound, 
                    Success = false, 
                    Message = $"Não foi encontrado ser vivo com o id '{livingBeing.Id}'",
                    Data = null
                };
            }

            return new ServiceResponse<LivingBeingModel>()
            {
                Status = StatusCodes.Status200OK,
                Success = true,
                Message = "Ser vivo atualizado com sucesso",
                Data = response,
            };
        }
        catch (Exception ex)
        {
            return new ServiceResponse<LivingBeingModel>()
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
using AquarioMania.Models;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AquarioMania.Service;

public class LivingBeingService : ILivingBeingInterface
{
    private readonly ApplicationDbContext _context;
    public LivingBeingService(ApplicationDbContext context)
    {
        _context = context;
    }

    public async Task<ServiceResponse<List<LivingBeingModel>>> GetLivingBeing()
    {
        ServiceResponse<List<LivingBeingModel>> serviceResponse = new ServiceResponse<List<LivingBeingModel>>();

        try
        {
            serviceResponse.Data = _context.LivingBeing.ToList();
            serviceResponse.Message = "Seres vivos retornados com sucesso!";
            serviceResponse.Status = 200;

            if(serviceResponse.Data.Count == 0)
            {
                serviceResponse.Message = "Nenhum dado encontrado!";
                serviceResponse.Success = false;
            }

        }
        catch (Exception ex)
        {
            serviceResponse.Status = 500;
            serviceResponse.Error = "InternalServerError";
            serviceResponse.Message = ex.Message;
            serviceResponse.Success = false;

        }

        return serviceResponse;
    }
    public async Task<ServiceResponse<LivingBeingModel>> GetLivingBeingById(int id)
    {
        ServiceResponse<LivingBeingModel> serviceResponse = new ServiceResponse<LivingBeingModel>();

        try
        {
            LivingBeingModel livingBeing = _context.LivingBeing.FirstOrDefault(x => x.Id == id);

            serviceResponse.Data = livingBeing;
            serviceResponse.Message = "Ser vivo retornado com sucesso!";
            serviceResponse.Status = 200;

            if (livingBeing is null)
            {
                serviceResponse.Message = $"Nenhum ser vivo encontrado com o id {id}.";
                serviceResponse.Success = false;
            }

            return serviceResponse;
        }
        catch (Exception ex)
        {
            serviceResponse.Status = 500;
            serviceResponse.Error = "InternalServerError";
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<LivingBeingModel>> CreateLivingBeing(LivingBeingModel livingBeing)
    {
        ServiceResponse<LivingBeingModel> serviceResponse = new ServiceResponse<LivingBeingModel>();

        try
        {
            if(livingBeing is null)
            {
                serviceResponse.Data = null;
                serviceResponse.Success = false;
                serviceResponse.Message = "Informar dados!";

                return serviceResponse;
            }

            _context.Add(livingBeing);
            await _context.SaveChangesAsync();

            serviceResponse.Data = _context.LivingBeing.FirstOrDefault(x => x.Id == livingBeing.Id);
            serviceResponse.Status = 201;
            serviceResponse.Message = "Ser vivo criado com sucesso!";
        }
        catch (Exception ex)
        {
            serviceResponse.Status = 500;
            serviceResponse.Error = "InternalServerError";
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message;
        }

        return serviceResponse;
    }

    public async Task<ServiceResponse<List<LivingBeingModel>>> UpdateLivingBeing(LivingBeingModel livingBeing)
    {
        ServiceResponse<List<LivingBeingModel>> serviceResponse = new ServiceResponse<List<LivingBeingModel>>();

        try
        {

            if (livingBeing is null)
            {
                serviceResponse.Message = $"Nenhum ser vivo encontrado.";
                serviceResponse.Success = false;
            }

            livingBeing.Updated_at = DateTime.Now.ToLocalTime();

            _context.Entry(livingBeing).State = EntityState.Modified;
            await _context.SaveChangesAsync();

            serviceResponse.Data = _context.LivingBeing.ToList();
            serviceResponse.Message = "Ser vivo atualizado com sucesso!";
            serviceResponse.Status = 200;

           
        }
        catch (Exception ex)
        {
            serviceResponse.Status = 500;
            serviceResponse.Error = "InternalServerError";
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message; ;
        }

        return serviceResponse;
    }
    public async Task<ServiceResponse<List<LivingBeingModel>>> DeleteLivingBeing(int id)
    {
        ServiceResponse<List<LivingBeingModel>> serviceResponse = new ServiceResponse<List<LivingBeingModel>>();

        try
        {
            LivingBeingModel livingBeing = _context.LivingBeing.FirstOrDefault(x => x.Id == id);


            if (livingBeing is null)
            {
                serviceResponse.Message = $"Nenhum ser vivo encontrado.";
                serviceResponse.Success = false;

            } else
            {
                _context.LivingBeing.Remove(livingBeing);
                await _context.SaveChangesAsync();

                serviceResponse.Message = "Ser vivo deletado com sucesso!";
                serviceResponse.Data = _context.LivingBeing.ToList();
            }
           
        }
        catch (Exception ex)
        {
            serviceResponse.Status = 500;
            serviceResponse.Error = "InternalServerError";
            serviceResponse.Success = false;
            serviceResponse.Message = ex.Message; ;
        }

        return serviceResponse;

    }
}
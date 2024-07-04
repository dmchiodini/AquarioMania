﻿using AquarioMania.Models.LivingBeing;
using AquarioMania.Repository;
using Microsoft.AspNetCore.Http.HttpResults;
using Microsoft.EntityFrameworkCore;

namespace AquarioMania.Service;

public class LivingBeingService : ILivingBeingInterface
{
    private readonly ILivingBeingRepository _livingBeingRepository;
    public LivingBeingService(ILivingBeingRepository livingBeingRepository)
    {
        _livingBeingRepository = livingBeingRepository;
    }

    public async Task<LivingBeingModel> CreateLivingBeing(LivingBeingModel livingBeing)
    {
        try
        {
            var create = await _livingBeingRepository.CreateLivingBeing(livingBeing);
            return create;
        }
        catch (Exception ex)
        {
            throw new Exception("Exception while creating livingBeing", ex);
        }
    }

    public async Task<LivingBeingModel> DeleteLivingBeing(int id)
    {
        try
        {
            var response = await _livingBeingRepository.DeleteLivingBeing(id);  
            return response;
        }
        catch (Exception ex)
        {
            throw new Exception("Exception while retrieving livingBeing", ex);
        }
    }

    public async Task<IEnumerable<ListLivingBeingModel>> GetLivingBeing()
    {
        try
        {
            var response = await _livingBeingRepository.GetLivingBeing();
            return response;
        }
        catch (Exception ex)
        {
            throw new Exception("Exception while retrieving livingBeing", ex);
        }
    }

    public async Task<ListLivingBeingModel> GetLivingBeingById(int id)
    {
        try
        {
            var response = await _livingBeingRepository.GetLivingBeingById(id);
            return response;
        }
        catch (Exception ex)
        {
            throw new Exception(" Exception while retrieving livingBeing", ex);
        }
    }

    public async Task<LivingBeingModel> UpdateLivingBeing(LivingBeingModel livingBeing)
    {
        try
        {
            var response = await _livingBeingRepository.UpdateLivingBeing(livingBeing);
            return response;
        }
        catch (Exception ex)
        {
            throw new Exception(" Exception while updating livingBeing", ex);
        }
    }
}
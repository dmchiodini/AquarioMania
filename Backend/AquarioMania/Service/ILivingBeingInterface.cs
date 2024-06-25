using AquarioMania.Models;

namespace AquarioMania.Service;

public interface ILivingBeingInterface
{
    Task<ServiceResponse<List<LivingBeingModel>>> GetLivingBeing();
    Task<ServiceResponse<LivingBeingModel>> CreateLivingBeing(LivingBeingModel livingBeing);
    Task<ServiceResponse<LivingBeingModel>> GetLivingBeingById(int id);
    Task<ServiceResponse<List<LivingBeingModel>>> UpdateLivingBeing(LivingBeingModel livingBeing);
    Task<ServiceResponse<List<LivingBeingModel>>> DeleteLivingBeing(int id);
}

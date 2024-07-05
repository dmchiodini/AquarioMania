using AquarioMania.Models;
using AquarioMania.Models.LivingBeing;

namespace AquarioMania.Service;

public interface ILivingBeingInterface
{
    Task<ServiceResponse<IEnumerable<ListLivingBeingModel>>> GetLivingBeing();
    Task<ServiceResponse<LivingBeingModel>> CreateLivingBeing(LivingBeingModel livingBeing, string token);
    Task<ServiceResponse<ListLivingBeingModel>> GetLivingBeingById(int id);
    Task<ServiceResponse<LivingBeingModel>> UpdateLivingBeing(LivingBeingModel livingBeing, string token);
    Task<ServiceResponse<LivingBeingModel>> DeleteLivingBeing(int id);
}

using AquarioMania.Models.LivingBeing;

namespace AquarioMania.Service;

public interface ILivingBeingInterface
{
    Task<IEnumerable<ListLivingBeingModel>> GetLivingBeing();
    Task<LivingBeingModel> CreateLivingBeing(LivingBeingModel livingBeing);
    Task<ListLivingBeingModel> GetLivingBeingById(int id);
    Task<LivingBeingModel> UpdateLivingBeing(LivingBeingModel livingBeing);
    Task<LivingBeingModel> DeleteLivingBeing(int id);
}

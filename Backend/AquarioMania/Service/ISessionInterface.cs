using AquarioMania.Models;
using AquarioMania.Models.Session;
using AquarioMania.Models.User;

namespace AquarioMania.Service
{
    public interface ISessionInterface
    {
        Task<ServiceResponse<SessionModel>> CreateSession(CreateSessionModel createSession);

    }
}

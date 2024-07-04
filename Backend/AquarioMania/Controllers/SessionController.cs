using AquarioMania.DataContext;
using AquarioMania.Models;
using AquarioMania.Models.Session;
using AquarioMania.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace AquarioMania.Controllers;

[Route("api/[controller]")]
[ApiController]
public class SessionController : ControllerBase
{
    private readonly ISessionInterface _service;

    public SessionController(ISessionInterface service)
    {
        _service = service;
    }

    [HttpPost]
    public async Task<ActionResult<ServiceResponse<SessionModel>>> CreateSession(CreateSessionModel createSession)
    {
        try
        {
            var response = await _service.CreateSession(createSession);

            if(response.Status == 401)
            {
                return StatusCode(StatusCodes.Status401Unauthorized, response);
            }

            return StatusCode(StatusCodes.Status201Created, response);
        }
        catch (Exception ex)
        {
            throw new Exception($"Exception while creating session! {ex}");
        }
        
    }
}

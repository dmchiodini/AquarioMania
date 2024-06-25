using AquarioMania.Models;
using AquarioMania.Service;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;

namespace AquarioMania.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivingBeingController : ControllerBase
    {
        private readonly ILivingBeingInterface _livingBeingInterface;

        public LivingBeingController(ILivingBeingInterface livingBeingInterface)
        {
            _livingBeingInterface = livingBeingInterface;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<List<LivingBeingModel>>>> GetLivingBeing() 
        {
        return Ok(await _livingBeingInterface.GetLivingBeing());
        }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> GetLivingBeingById(int id)
        {
           return Ok(await _livingBeingInterface.GetLivingBeingById(id));
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> CreateLivingBeing(LivingBeingModel livingBeing)
        {
            return Ok(await _livingBeingInterface.CreateLivingBeing(livingBeing));
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<List<LivingBeingModel>>>> UpdateLivingBeing(LivingBeingModel livingBeing)
        { 
            return Ok(await _livingBeingInterface.UpdateLivingBeing(livingBeing));
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<LivingBeingModel>>>> DeleteLivingBeing(int id)
        {
            return Ok(await _livingBeingInterface.DeleteLivingBeing(id));
        }
    }
}

using AquarioMania.Models;
using AquarioMania.Models.LivingBeing;
using AquarioMania.Service;
using Azure;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AquarioMania.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    [Authorize]
    public class LivingBeingController : ControllerBase
    {
        private readonly ILivingBeingInterface _service;

        public LivingBeingController(ILivingBeingInterface service)
        {
            _service = service;
        }

        [HttpGet]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ListLivingBeingModel>>>> GetLivingBeing() 
        {           
            var response = await _service.GetLivingBeing();    
            return response;
        }

        [HttpGet("{id}")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Response<ListLivingBeingModel>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ServiceResponse<ListLivingBeingModel>>> GetLivingBeingById(int id)
        {
            var response = await _service.GetLivingBeingById(id);
            return response;
        }

        [HttpPost]
        [ProducesResponseType(StatusCodes.Status201Created)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Response<LivingBeingModel>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> CreateLivingBeing(LivingBeingModel livingBeing)
        {
            var token = Request.Headers["Authorization"];
            var createdLivingBeing = await _service.CreateLivingBeing(livingBeing, token);
            return createdLivingBeing;
        }

        [HttpPut]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Response<LivingBeingModel>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> UpdateLivingBeing(LivingBeingModel livingBeing)
        {
            var token = Request.Headers["Authorization"];
            var updatedLivingBeing = await _service.UpdateLivingBeing(livingBeing, token);
            return updatedLivingBeing;
        }

        [HttpDelete]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status400BadRequest)]
        [ProducesResponseType(StatusCodes.Status401Unauthorized)]
        [ProducesResponseType(typeof(Response<LivingBeingModel>), StatusCodes.Status500InternalServerError)]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> DeleteLivingBeing(int id)
        {
            var response = await _service.DeleteLivingBeing(id);
            return response;
        }
    }
}

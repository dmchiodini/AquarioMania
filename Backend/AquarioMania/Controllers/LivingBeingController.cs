using AquarioMania.Models;
using AquarioMania.Models.LivingBeing;
using AquarioMania.Service;
using Azure;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.ComponentModel.DataAnnotations;

namespace AquarioMania.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class LivingBeingController : ControllerBase
    {
        private readonly ILivingBeingInterface _service;

        public LivingBeingController(ILivingBeingInterface service)
        {
            _service = service;
        }

        [HttpGet]
        public async Task<ActionResult<ServiceResponse<IEnumerable<ListLivingBeingModel>>>> GetLivingBeing() 
        {
            try
            {
                var response = await _service.GetLivingBeing();
                return StatusCode(StatusCodes.Status200OK, new ServiceResponse<IEnumerable<ListLivingBeingModel>>()
                {
                    Status = StatusCodes.Status200OK,
                    Success = true,
                    Message = response.Count() == 0 ? "Não há seres vivos cadastrados" : "Seres vivos retornados com sucesso",
                    Data = response,
                });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
            }
           
    }
        [HttpGet("{id}")]
        public async Task<ActionResult<ServiceResponse<ListLivingBeingModel>>> GetLivingBeingById(int id)
        {
            try
            {
                var response = await _service.GetLivingBeingById(id);

                if(response == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, new ServiceResponse<ListLivingBeingModel>() { Status = StatusCodes.Status404NotFound, Success = false, Message = $"Não foi encontrado ser vivo com o id '{id}'" });
                }

                return StatusCode(StatusCodes.Status200OK, new ServiceResponse<ListLivingBeingModel>()
                {
                    Status = StatusCodes.Status200OK,
                    Success = true,
                    Message = "Ser vivo retornado com sucesso",
                    Data = response,
                });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
            }
        }

        [HttpPost]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> CreateLivingBeing(LivingBeingModel livingBeing)
        {
            try
            {
                var createdLivingBeing = await _service.CreateLivingBeing(livingBeing);
                return StatusCode(StatusCodes.Status201Created, new ServiceResponse<LivingBeingModel>()
                {
                    Status = StatusCodes.Status201Created,
                    Success = true,
                    Message = "Ser vivo criado com sucesso",
                    Data = createdLivingBeing,
                });

            }catch(Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
            }
        }

        [HttpPut]
        public async Task<ActionResult<ServiceResponse<LivingBeingModel>>> UpdateLivingBeing(LivingBeingModel livingBeing)
        {

            try
            {
                var updatedLivingBeing = await _service.UpdateLivingBeing(livingBeing);

                if (updatedLivingBeing == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status404NotFound, Success = false, Message = $"Não foi encontrado ser vivo com o id '{livingBeing.Id}'" });
                }

                return StatusCode(StatusCodes.Status200OK, new ServiceResponse<LivingBeingModel>()
                {
                    Status = StatusCodes.Status200OK,
                    Success = true,
                    Message = "Ser vivo atualizado com sucesso",
                    Data = updatedLivingBeing,
                });
            }
            catch (Exception ex)
            {

                return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message }); ;
            }
        }

        [HttpDelete]
        public async Task<ActionResult<ServiceResponse<List<LivingBeingModel>>>> DeleteLivingBeing(int id)
        {
            try
            {

                var getById = await _service.GetLivingBeingById(id);

                if (getById == null)
                {
                    return StatusCode(StatusCodes.Status404NotFound, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status404NotFound, Success = false, Message = $"Não foi encontrado ser vivo com o id '{id}'" });
                }

                var deleteLivingBeing = await _service.DeleteLivingBeing(id);

                return StatusCode(StatusCodes.Status200OK, new ServiceResponse<LivingBeingModel>()
                {
                    Status = StatusCodes.Status200OK,
                    Success = true,
                    Message = "Ser vivo deletado com sucesso",
                    Data = deleteLivingBeing,
                });

            }
            catch (Exception ex)
            {
                return StatusCode(StatusCodes.Status500InternalServerError, new ServiceResponse<LivingBeingModel>() { Status = StatusCodes.Status500InternalServerError, Success = false, Message = ex.Message });
            }
        }
    }
}

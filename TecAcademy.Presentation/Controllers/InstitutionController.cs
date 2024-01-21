using FluentValidation;
using Microsoft.AspNetCore.Mvc;
using TecAcademy.Services.Contracts;
using TecAcademy.Services.Contracts.Institutions;
using TecAcademy.Services.Interfaces;

namespace TecAcademy.Presentation.Controllers
{
    [Route("api/institutions")]
    [ApiController]
    public class InstitutionController : ControllerBase
    {
        private readonly ILogger<InstitutionController> _logger;
        private readonly IInstitutionService _institutionService;
        private readonly IValidator<InstitutionCreateReq> _validator;

        public InstitutionController(
         IInstitutionService institutionService,
         IValidator<InstitutionCreateReq> validator,
         ILogger<InstitutionController> logger)
        {
            _institutionService = institutionService;
            _validator = validator;
            _logger = logger;
        }

        [HttpPost]
        public ActionResult<BaseResponse> Create(
         [FromBody] InstitutionCreateReq req)
        {
            var validationResult = _validator.Validate(req);

            if(!validationResult.IsValid)
            {
               return BadRequest(validationResult);
            }

            return Ok(_institutionService.Create(req));
        }

        [HttpGet]
        public async Task<ActionResult<BaseResponse>> GetAll()
        {
            return await _institutionService.GetAll();
        }

        [HttpGet]
        [Route("{instituionId}")]
        public async Task<ActionResult<BaseResponse>> Get(Guid  instituionId )
        {
            return await _institutionService.GetById(instituionId);
        }

        [HttpPut]
        [Route("{instituionId}")]
        public async Task<ActionResult<BaseResponse>> Update(
            Guid instituionId, 
            [FromBody]InstitutionUpdateReq req)
        {
            return await _institutionService.Update(req);
        }

        [HttpDelete]
        [Route("{id}")]
        public async Task<ActionResult<BaseResponse>> Delete(string id)
        {
            return await _institutionService.Delete(new Guid(id));
        }
    }
}

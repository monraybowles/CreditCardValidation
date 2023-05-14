using Business.Abstract;
using Core.Entities.Concrete;
using Microsoft.AspNetCore.Mvc;

namespace WebAPI.Controllers
{

    [Route("api/[controller]")]
    [ApiController]
    public class CreditCardValidationsController : ControllerBase
    {
        ICardService _CreditCardValidationsService;

        public CreditCardValidationsController(ICardService CreditCardValidationsService)
        {
            _CreditCardValidationsService = CreditCardValidationsService;
        }

        [HttpGet("getall")]
        public IActionResult Get()
        {
            var result = _CreditCardValidationsService.GetAll();
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpGet("getbyid")]
        public IActionResult Get(Guid id)
        {
            var result = _CreditCardValidationsService.GetById(id);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpPost("add")]
        public IActionResult Add(CreditCardValidation CreditCardValidations)
        {
            var result = _CreditCardValidationsService.Add(CreditCardValidations);
            return result.Success ? Ok(result) : BadRequest(result);
        }

        [HttpDelete("delete")]
        public IActionResult Delete(CreditCardValidation CreditCardValidations)
        {

            var result = _CreditCardValidationsService.Delete(CreditCardValidations);
            return result.Success ? Ok(result) : BadRequest(result);

        }

        [HttpPut("update")]
        public IActionResult Update(CreditCardValidation CreditCardValidations)
        {

            var result = _CreditCardValidationsService.Update(CreditCardValidations);
            return result.Success ? Ok(result) : BadRequest(result);

        }
    }
}

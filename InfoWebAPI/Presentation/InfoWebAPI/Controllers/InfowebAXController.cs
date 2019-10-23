using InfoWebAPI.Application.InfoService.InfoWebAX;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace InfoWebAPI.Controllers
{
    [Authorize]
    [Route("api/InfoService/[controller]")]
    [ApiController]
    public class InfowebAXController : ControllerBase
    {
        private readonly IMediator _mediator;

        public InfowebAXController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet("GetAllPrintTemplates")]
        public async Task<IActionResult> GetAllPrintTemplates([FromQuery] [BindRequired] int accountId)
        {
            var request = new GetAllPrintTemplatesRequest
            {
                AccountId = accountId
            };
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetCoreDetails")]
        public async Task<IActionResult> GetCoreDetails([FromQuery] [BindRequired] GetCoreDetailsRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetCoreDetailsByCardNumber")]
        public async Task<IActionResult> GetCoreDetailsByCardNumber([FromQuery] [BindRequired] GetCoreDetailsByCardNumberRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetCoreDetailsByOtherBarcode")]
        public async Task<IActionResult> GetCoreDetailsByOtherBarcode([FromQuery] [BindRequired] GetCoreDetailsByOtherBarcodeRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetShowSettings")]
        public async Task<IActionResult> GetShowSettings([FromQuery] [BindRequired] GetShowSettingsRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetScreenMessages")]
        public async Task<IActionResult> GetScreenMessages([FromQuery] [BindRequired] GetScreenMessagesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetBarcodes")]
        public async Task<IActionResult> GetBarcodes([FromQuery] [BindRequired] GetBarcodesRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("AddNewBarcode")]
        public async Task<IActionResult> AddNewBarcode([FromQuery] [BindRequired] AddNewBarcodeRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("UpdateRecord")]
        public async Task<IActionResult> UpdateRecord([FromBody]UpdateRecordRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetStatusByContact")]
        public async Task<IActionResult> GetStatusByContact([FromQuery] [BindRequired] GetStatusByContactRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
using InfoWebAPI.Application.ListAccount;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.ModelBinding;
using System.Threading.Tasks;

namespace InfoWebAPI.Controllers
{
    [Authorize]
    [Route("api/[controller]")]
    [ApiController]
    public class AccountsController : ControllerBase
    {
        private readonly IMediator _mediator;

        public AccountsController(IMediator mediator)
        {
            _mediator = mediator;
        }

        [HttpGet]
        public async Task<IActionResult> GetAccountList([FromQuery] [BindRequired] int userId)
        {
            var accountListRequest = new ListAccountRequest
            {
                UserId = userId
            };
            var response = await _mediator.Send(accountListRequest);
            return Ok(response);
        }
    }
}
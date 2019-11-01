using InfoWebAPI.Core.Application.Account;
using InfoWebAPI.Core.Application.AccountUser;
using InfoWebAPI.Core.Application.User;
using InfoWebAPI.Core.Application.UserPermission;
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
    public class CoreController : ControllerBase
    {
        private readonly IMediator _mediator;

        public CoreController(IMediator mediator)
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

        [HttpGet("GetAccount")]
        public async Task<IActionResult> GetAccount([FromQuery] [BindRequired] int accountId)
        {
            var account = new GetAccountRequest
            {
                AccountId = accountId
            };
            var response = await _mediator.Send(account);
            return Ok(response);
        }

        [HttpGet("ListAccount")]
        public async Task<IActionResult> ListAccount([FromQuery] [BindRequired] ListAccountRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("ListAccountUser")]
        public async Task<IActionResult> ListAccountUser([FromQuery] [BindRequired] ListAccountUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("AddAccountUser")]
        public async Task<IActionResult> AddAccountUser([FromBody] AddAccountUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("DeleteAccountUser")]
        public async Task<IActionResult> DeleteAccountUser([FromQuery] [BindRequired] DeleteAccountUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("AddUser")]
        public async Task<IActionResult> AddUser([FromBody] AddUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpDelete("DeleteUser")]
        public async Task<IActionResult> DeleteUser([FromQuery] [BindRequired] DeleteUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetUser")]
        public async Task<IActionResult> GetUser([FromQuery] [BindRequired] GetUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("ListUser")]
        public async Task<IActionResult> ListUser()
        {
            var response = await _mediator.Send(new ListUserRequest());
            return Ok(response);
        }

        [HttpPost("UpdateUser")]
        public async Task<IActionResult> UpdateUser([FromBody] UpdateUserRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpGet("GetUserPermission")]
        public async Task<IActionResult> GetUserPermission([FromQuery] [BindRequired] GetUserPermissionRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }

        [HttpPost("UpdateUserPermission")]
        public async Task<IActionResult> UpdateUserPermission([FromBody] UpdateUserPermissionRequest request)
        {
            var response = await _mediator.Send(request);
            return Ok(response);
        }
    }
}
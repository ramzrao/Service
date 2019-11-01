using InfoWebAPI.Attributes;
using InfoWebAPI.Common.Attributes;
using MediatR;
using Microsoft.AspNetCore.Authorization;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace InfoWebAPI.Controllers
{
    [Authorize]
    [Route("api/InfoService/")]
    [GenericControllerName]
    public class GenericDeleteController<T> : BaseController
    {
        public GenericDeleteController(IMediator mediator) : base(mediator)
        {
        }

        [HttpDelete]
        [GenericActionName]
        public async Task<IActionResult> Post([FromQuery]T request) => await HandleRequest<T>(request);
    }
}
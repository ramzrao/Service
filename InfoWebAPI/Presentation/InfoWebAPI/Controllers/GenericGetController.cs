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
    public class GenericGetController<T> : BaseController
    {
        public GenericGetController(IMediator mediator) : base(mediator)
        {
        }

        [HttpGet]
        [GenericActionName]
        public async Task<IActionResult> Get([FromQuery]T request) => await HandleRequest<T>(request);
    }
}
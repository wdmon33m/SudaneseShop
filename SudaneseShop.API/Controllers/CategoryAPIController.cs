using Asp.Versioning;
using Microsoft.AspNetCore.Mvc;
using SudaneseShop.API.Models;
using System.Net;

namespace SudaneseShop.API.Controllers
{
    [Route("api/v{version:apiVersion}/category")]
    [ApiController]
    [ApiVersion("1.0")]
    public class CategoryAPIController : ControllerBase
    {
        private readonly ResponseDto _response;

        public CategoryAPIController()
        {
            _response = new();
        }
        [HttpGet]
        [MapToApiVersion("1.0")]
        [ResponseCache(CacheProfileName ="Default30")]
        [ProducesResponseType(StatusCodes.Status200OK)]
        [ProducesResponseType(StatusCodes.Status404NotFound)]
        [ProducesResponseType(StatusCodes.Status500InternalServerError)]
        public ResponseDto Get()
        {
            return _response.BadRequest("error1","error2");
        }
    }
}

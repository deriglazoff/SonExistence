using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SonExistence.Dto;
using SonExistence.Interfaces;
using SonExistence.Models;
using System.Threading.Tasks;

namespace SonExistence.Controllers
{
    [ApiController]
    [Route("api/online-cashier/[controller]")]
    public class DocumentController : ControllerBase
    {
        private readonly IRepository _repository;
        public DocumentController(IRepository observable)
        {
            _repository = observable;
        }

        /// <summary>
        /// Регистрация документа
        /// </summary>
        /// <returns>200</returns>
        [HttpPost]
        [ProducesResponseType(typeof(Response), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType(typeof(ProblemDetails))]

        public async Task<IActionResult> Send([FromBody] DocumentDto message)
        {
            var result = _repository.Save(message);
            return Ok(result);
        }
    }
}

using System.Collections.Generic;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using SonExistence.Dto;
using SonExistence.Interfaces;
using SonExistence.Models;
using System.Threading.Tasks;

namespace SonExistence.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class BabyController : ControllerBase
    {
        private readonly IRepository _repository;
        public BabyController(IRepository observable)
        {
            _repository = observable;
        }

        /// <summary>
        /// Испугать
        /// </summary>
        /// <returns>Крик</returns>
        [HttpGet]
        [ProducesResponseType(typeof(Cry), StatusCodes.Status200OK)]
        [ProducesDefaultResponseType(typeof(ProblemDetails))]

        public async Task<IActionResult> Cringe()
        {
            return Ok(new Cry());
        }

        /// <summary>
        /// 
        /// </summary>
        /// <returns>Крик</returns>
        [HttpGet]
        [ProducesResponseType(IEnumerable<Child>, StatusCodes.Status200OK)]
        [ProducesDefaultResponseType(typeof(ProblemDetails))]

        public async Task<IActionResult> Children()
        {
            return Ok(new List<Child>());
        }

    }
}

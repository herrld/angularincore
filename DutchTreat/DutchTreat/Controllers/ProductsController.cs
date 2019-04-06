using Microsoft.AspNetCore.Mvc;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace DutchTreat.Controllers
{
    [Route("api/[Controller]")]
    [ApiController]
    [Produces("application/json")]
    public class ProductsController: Controller
    {

        [HttpGet]
        [ProducesResponseType(200)]
        [ProducesResponseType(400)]
        public ActionResult<string> Get()
        {
            try
            {
                return Ok("stuff");
            }
            catch( Exception ex)
            {
                return BadRequest("its bad mkay");
            }
        }
    }
}

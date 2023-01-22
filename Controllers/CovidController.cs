using apiCOVID.Models;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiCOVID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidController : ControllerBase
    {
        [HttpGet]
        public ActionResult <List<CovidModel>> BuscarDadosCovid()
        {
            return Ok();
        }
    }
}

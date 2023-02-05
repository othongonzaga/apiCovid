using apiCOVID.Models;
using apiCOVID.Repositorios.Interfaces;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;

namespace apiCOVID.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CovidController : ControllerBase
    {
        private readonly ICovid _covidRepositorio;

        public CovidController(ICovid covidRepositorio)
        {
            _covidRepositorio = covidRepositorio;
        }

        [HttpGet]
        public ActionResult <IEnumerable<CovidModel>> BuscarDadosCovidPorMunicipio(int codmun)
        {
            IEnumerable<CovidModel> covid = _covidRepositorio.BuscarDadosCovidPorMunicipio(codmun);
            return Ok(covid);
        }

        [HttpGet]
        public ActionResult<IEnumerable<CovidModel>> BuscarDadosCovidPorUF(int coduf)
        {
            IEnumerable<CovidModel> covid = _covidRepositorio.BuscarDadosCovidPorUF(coduf);
            return Ok(covid);
        }
    }
}

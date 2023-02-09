using apiCOVID.Data;
using apiCOVID.Models;
using apiCOVID.Repositorios.Interfaces;
using Microsoft.AspNetCore.Connections;
using Microsoft.EntityFrameworkCore;
using System.Linq;

namespace apiCOVID.Repositorios
{
    public class CovidRepositorio : ICovid
    {
        private readonly apiCovidDBContext _dbContext;

        public CovidRepositorio(apiCovidDBContext apiCovidDBContext)
        {
            _dbContext = apiCovidDBContext;
        }

        public IEnumerable<CovidModel> BuscarDadosCovidPorMunicipio(int codmun)
        {
            return _dbContext.CovidDados.Where(x => x.codmun == codmun);
        }

        public IEnumerable<CovidModel> BuscarDadosCovidPorUF(int coduf)
        {
            return  _dbContext.CovidDados.Where(x => x.coduf == coduf);
        }

        public bool ListarRomulo()
        {
            IEnumerable<CovidModel>  query=   from CovidDados
                                              select regiao;
        }
    }
}

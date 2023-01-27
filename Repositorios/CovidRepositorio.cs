﻿using apiCOVID.Data;
using apiCOVID.Models;
using apiCOVID.Repositorios.Interfaces;
using Microsoft.EntityFrameworkCore;

namespace apiCOVID.Repositorios
{
    public class CovidRepositorio : ICovid
    {
        private readonly apiCovidDBContext _dbContext;

        public CovidRepositorio(apiCovidDBContext apiCovidDBContext)
        {
            _dbContext = apiCovidDBContext;
        }

        public async Task<IEnumerable<CovidModel>> BuscarDadosCovidPorMunicipio(int codmun)
        {
            return await _dbContext.CovidDados.Where(x => x.codmun == codmun);
        }

        public async Task<IEnumerable<CovidModel>> BuscarDadosCovidPorUF(int coduf)
        {
            return await _dbContext.CovidDados.Where(x => x.coduf == coduf);
        }
    }
}

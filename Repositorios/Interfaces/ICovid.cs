using apiCOVID.Models;

namespace apiCOVID.Repositorios.Interfaces
{
    public interface ICovid
    {
        Task<IEnumerable<CovidModel>> BuscarDadosCovidPorMunicipio(int coduf);
        Task<IEnumerable<CovidModel>> BuscarDadosCovidPorUF(int codmun);
    }
}

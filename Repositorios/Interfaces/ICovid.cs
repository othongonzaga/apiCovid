using apiCOVID.Models;

namespace apiCOVID.Repositorios.Interfaces
{
    public interface ICovid
    {
        IEnumerable<CovidModel> BuscarDadosCovidPorMunicipio(int coduf);
        IEnumerable<CovidModel> BuscarDadosCovidPorUF(int codmun);
    }
}

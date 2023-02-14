using apiCOVID.Models;

namespace apiCOVID.Repositorios.Interfaces
{
    public interface ICovid
    {
        IEnumerable<CovidModel> BuscarDadosCovidPorMunicipio(int codmun);
        IEnumerable<CovidModel> BuscarDadosCovidPorUF(int coduf);
        IEnumerable<CovidModel> ListarMunicipioMaisCasos();
        IEnumerable<CovidModel> ListarMunicipioMaisObitos();
    }
}

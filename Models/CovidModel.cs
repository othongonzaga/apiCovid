using Microsoft.EntityFrameworkCore;

namespace apiCOVID.Models
{
    [Keyless]
    public class CovidModel
    {
        
        public string regiao { get; set; } 
        public string? estado { get; set; }
        public string? municipio { get; set; } 
        public int coduf  { get; set; }
        public int? codmun { get; set; }
        public int? codRegiaoSaude { get; set; }
        public string? nomeRegiaoSaude { get; set; } 
        public DateTime data { get; set; }
        public int semanaEpi { get; set; }
        public int? populacaoTCU2019 { get; set; }
        public int? casosAcumulado { get; set; }
        public int? casosNovos { get; set; }
        public int? obitosAcumulado { get; set; }
        public int? obitosNovos { get; set; }
        public int Recuperadosnovos { get; set; }
        public int emAcompanhamentoNovos { get; set; }
        public int?  interiorOUmetropolitana { get; set; }
}
}

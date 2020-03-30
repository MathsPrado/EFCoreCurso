using EFCORE_WEBAPI_E.Model;
using System.Collections.Generic;

namespace EFCORE.WEBAPI_E.Model
{
    public class Heroi
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public IdentidadeSecreta Identidade { get; set; }
        public List<Arma> Armas { get; set; }
        public List<HeroiBatalha> HeroisBatalhas { get; set; }


    }
}

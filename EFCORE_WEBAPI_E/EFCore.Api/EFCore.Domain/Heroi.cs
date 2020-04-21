using EFCore.Domain;
using System;
using System.Collections.Generic;
using System.Text;

namespace EFCore.Dominio
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

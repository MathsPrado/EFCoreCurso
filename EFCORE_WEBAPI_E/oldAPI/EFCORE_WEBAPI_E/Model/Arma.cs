namespace EFCORE.WEBAPI_E.Model
{
    public class Arma
    {
        public int Id { get; set; }
        public string Nome { get; set; }
        public Heroi Heroi { get; set; }
        public int HeroiId { get; set; }
    }
}

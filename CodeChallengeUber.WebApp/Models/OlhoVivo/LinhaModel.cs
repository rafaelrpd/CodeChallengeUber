namespace CodeChallengeUber.WebApp.Models.OlhoVivo
{
    public class Linha
    {
        public int Cl { get; set; }
        public bool Lc { get; set; }
        public string Lt { get; set; }
        public int Tl { get; set; }
        public int Sl { get; set; }
        public string Tp { get; set; }
        public string Ts { get; set; }
    }

    public class BuscarLinhasRequest
    {
        public string TermosBusca { get; set; }
    }

    public class BuscarLinhaSentidoRequest
    {
        public string TermosBusca { get; set; }
        public byte Sentido { get; set; }
    }
}
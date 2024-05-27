namespace CodeChallengeUber.WebApp.Models.OlhoVivo
{
    public class Veiculo
    {
        public int P { get; set; }
        public bool A { get; set; }
        public string Ta { get; set; }
        public double Py { get; set; }
        public double Px { get; set; }
    }

    public class LinhaPosicao
    {
        public string C { get; set; }
        public int Cl { get; set; }
        public int Sl { get; set; }
        public string Lt0 { get; set; }
        public string Lt1 { get; set; }
        public int Qv { get; set; }
        public List<Veiculo> Vs { get; set; }
    }

    public class PosicaoVeiculosResponse
    {
        public string Hr { get; set; }
        public List<LinhaPosicao> L { get; set; }
    }
}
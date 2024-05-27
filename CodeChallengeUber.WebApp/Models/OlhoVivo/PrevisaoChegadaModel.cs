namespace CodeChallengeUber.WebApp.Models.OlhoVivo
{
    public class PrevisaoChegada
    {
        public int Cp { get; set; }
        public string Np { get; set; }
        public double Py { get; set; }
        public double Px { get; set; }
        public List<LinhaPosicao> L { get; set; }
    }

    public class PrevisaoChegadaLinhaRequest
    {
        public int CodigoLinha { get; set; }
    }

    public class PrevisaoChegadaParadaRequest
    {
        public int CodigoParada { get; set; }
    }

    public class PrevisaoChegadaResponse
    {
        public string Hr { get; set; }
        public PrevisaoChegada P { get; set; }
    }
}
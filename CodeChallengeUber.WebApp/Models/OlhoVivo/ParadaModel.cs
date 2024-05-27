namespace CodeChallengeUber.WebApp.Models.OlhoVivo
{
    public class Parada
    {
        public int Cp { get; set; }
        public string Np { get; set; }
        public string Ed { get; set; }
        public double Py { get; set; }
        public double Px { get; set; }
    }

    public class BuscarParadasRequest
    {
        public string TermosBusca { get; set; }
    }

    public class BuscarParadasPorLinhaRequest
    {
        public int CodigoLinha { get; set; }
    }

    public class BuscarParadasPorCorredorRequest
    {
        public int CodigoCorredor { get; set; }
    }
}
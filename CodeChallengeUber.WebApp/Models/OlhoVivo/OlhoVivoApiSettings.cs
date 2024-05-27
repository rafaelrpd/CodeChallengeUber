namespace CodeChallengeUber.WebApp.Models.OlhoVivo
{
    public class OlhoVivoApiSettings
    {
        public string BaseUrl { get; set; }
        public string ApiKey { get; set; }
        public OlhoVivoApiEndpoints Endpoints { get; set; }
    }

    public class OlhoVivoApiEndpoints
    {
        public string Autenticar { get; set; }
        public string BuscarLinhas { get; set; }
        public string BuscarLinhaSentido { get; set; }
        public string BuscarParadas { get; set; }
        public string BuscarParadasPorLinha { get; set; }
        public string BuscarParadasPorCorredor { get; set; }
        public string GetCorredores { get; set; }
        public string GetEmpresas { get; set; }
        public string GetPosicao { get; set; }
        public string GetPosicaoLinha { get; set; }
        public string GetPosicaoGaragem { get; set; }
        public string GetPrevisaoChegada { get; set; }
        public string GetPrevisaoLinha { get; set; }
        public string GetPrevisaoParada { get; set; }
        public string GetVelocidadeVias { get; set; }
        public string GetVelocidadeCorredor { get; set; }
        public string GetVelocidadeOutrasVias { get; set; }
    }
}
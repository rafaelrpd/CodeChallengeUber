namespace CodeChallengeUber.WebApp.Models.OlhoVivo
{
    public class AutenticacaoRequest
    {
        public string Token { get; set; }
    }

    public class AutenticacaoResponse
    {
        public bool Success { get; set; }
    }
}
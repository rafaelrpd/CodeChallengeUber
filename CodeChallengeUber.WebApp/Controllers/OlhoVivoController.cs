using CodeChallengeUber.WebApp.Models.OlhoVivo;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Options;

namespace CodeChallengeUber.WebApp.Controllers
{
    public class OlhoVivoController : Controller
    {
        private readonly OlhoVivoApiSettings _olhoVivoApiSettings;
        private readonly HttpClient _httpClient;

        public OlhoVivoController(IOptions<OlhoVivoApiSettings> olhoVivoApiSettings, IHttpClientFactory httpClientFactory)
        {
            _olhoVivoApiSettings = olhoVivoApiSettings.Value;
            _httpClient = httpClientFactory.CreateClient();
        }

        #region Views

        public IActionResult Index()
        {
            return View();
        }

        #endregion Views

        [HttpPost]
        public async Task<IActionResult> Autenticar()
        {
            string url = $"{_olhoVivoApiSettings.BaseUrl}{_olhoVivoApiSettings.Endpoints.Autenticar.Replace("{token}", _olhoVivoApiSettings.ApiKey)}";

            var response = await _httpClient.PostAsync(url, null);
            if (response.IsSuccessStatusCode)
            {
                var content = await response.Content.ReadAsStringAsync();
                return Ok(content);
            }
            return BadRequest();
        }
    }
}
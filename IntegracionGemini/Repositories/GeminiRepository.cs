using IntegracionGemini.Interfaces;
using IntegracionGemini.Models;
using Microsoft.AspNetCore.Components.Web;
using Newtonsoft.Json;
using System.Text;
using System.Text.Json.Serialization;

namespace IntegracionGemini.Repositories
{
    public class GeminiRepository : IChatbotService
    {
        private readonly HttpClient _httpClient;
        private readonly string _apiKey;
        private readonly string _baseUrl;

        public GeminiRepository(IConfiguration configuration)
        {
            _httpClient = new HttpClient();
            _apiKey = configuration["Gemini:ApiKey"];
            _baseUrl = configuration["Gemini:BaseUrl"];
        }

        public async Task<string> ObtenerRespuestaChatbot(string prompt)
        {
            string url = $"{_baseUrl}?key={_apiKey}";
            GeminiRequest request = new GeminiRequest
            {
                contents = new List<GeminiContent>
                {
                    new GeminiContent
                    {
                        parts = new List<GeminiPart>
                        {
                            new GeminiPart { text = prompt }
                        }
                    }
                }
            };
            string json_data = JsonConvert.SerializeObject(request);
            var content = new StringContent(json_data, Encoding.UTF8, "application/json");
            var response = await _httpClient.PostAsync(url, content); //Para cada metodo asincrono poner await
            return await response.Content.ReadAsStringAsync();
        }

        public bool GuardarRespuestaBaseDatosLocal(string prompt, string respuesta)
        {
            throw new NotImplementedException();
        }
    }
}

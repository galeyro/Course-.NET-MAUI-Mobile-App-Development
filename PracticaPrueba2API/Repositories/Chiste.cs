using Newtonsoft.Json.Linq;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PracticaPrueba2API.Repositories
{
    internal class ChisteRepository
    {
        private readonly HttpClient _httpClient;

        public ChisteRepository()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetChisteAsync()
        {
            //guardo en una variable la respuesta
            var response = await _httpClient.GetStringAsync("https://official-joke-api.appspot.com/random_joke");
            //transformo la respuesta en un objeto manipulable
            var json = JObject.Parse(response);
            //accedo al valor clave setup, en caso de no existir devuelve null
            //es el inicio del chiste
            string setup = json["setup"]?.ToString();
            //accedo al valor clave punchline, en caso de no existir devuelve null
            //es el remate del chiste
            string punchline = json["punchline"]?.ToString();
            //devuelve texto con dos lineas separados por un salto de linea
            return $"{setup}\n{punchline}";
        }

    }
}

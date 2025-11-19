using ApiFeriadosDoAno.Class;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace ApiFeriadosDoAno.Service
{
    public class ApiService
    {
        private readonly static HttpClient _httpClient = new HttpClient();
        public async Task<List<Feriados>> GetAsync(int ano)
        {
            var response = await _httpClient.GetAsync("https://brasilapi.com.br/api/feriados/v1/" + ano + "");

            response.EnsureSuccessStatusCode();
            var json = await response.Content.ReadAsStringAsync();

            var feriados = JsonSerializer.Deserialize<List<Feriados>>(json);

            return feriados;
        }
    }
}

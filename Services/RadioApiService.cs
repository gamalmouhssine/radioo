using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using radioo.Models;
using System.Net.Http.Json;

namespace radioo.Services
{
    public class RadioApiService
    {
        private readonly HttpClient _httpClient;
        private const string BaseUrl = "https://de1.api.radio-browser.info/json";

        public RadioApiService()
        {
            _httpClient = new HttpClient();
        }

        public async Task<List<Country>> GetCountriesAsync()
        {
            var response = await _httpClient.GetFromJsonAsync<List<Country>>($"{BaseUrl}/countries");
            return response ?? new List<Country>();
        }

        public async Task<List<RadioStation>> GetStationsByCountryAsync(string countryName)
        {
            var response = await _httpClient.GetFromJsonAsync<List<RadioStation>>($"{BaseUrl}/stations/bycountry/{countryName}");
            return response ?? new List<RadioStation>();
        }
    }
}

using MidPointLocator.Models;
using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;

namespace MidPointLocator
{
    public class LocationRepository
    {
        private readonly string postcodeIOUrl;
        private readonly HttpClient httpClient;
        private readonly PostcodeFileImporter postcodeFileImporter;

        public LocationRepository(
            HttpClient httpClient,
            PostcodeFileImporter postcodeFileImporter
        )
        {
            this.httpClient = httpClient;
            this.postcodeFileImporter = postcodeFileImporter;
            postcodeIOUrl = Environment.GetEnvironmentVariable("POSTCODES_IO_URL") ?? "http://localhost:8000/postcodes";
        }
        public async Task<Response> GetLocations()
        {
            var postcodes = postcodeFileImporter.GetPostcodes();

            var serializedJson = JsonSerializer.Serialize(new Dictionary<string, List<string>> { { "postcodes", postcodes }});
            var content = new StringContent(serializedJson, Encoding.UTF8, "application/json");
            var result = await httpClient.PostAsync(postcodeIOUrl, content);
            using (var contentStream = await result.Content.ReadAsStreamAsync())
            {
                var response = await JsonSerializer.DeserializeAsync<Response>(contentStream);
                return response;
            }
        }
    }
}
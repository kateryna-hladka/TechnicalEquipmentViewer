using System.Net.Http;
using System.Text;

namespace TechnicalEquipmentViewer.Services
{
    public class ApiClient
    {
        private const string Url = "https://it-dev.kovalska.dev/DEV_TOR/ws/api/_MOBILEDATASYNC";
        private readonly HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> PostAsync()
        {
            var jsonBody = """
            {
                "Jsonrpc": "2.0",
                "Method": "TestMonitoringPlan",
                "Id": "0cd24fad-4422-41ad-83d8-f87bdfbe8aaa",
                "Params": {
                    "AppId": "RAM",
                    "PersonnelNumber": "000000",
                    "FactoryCode": "00005",
                    "Date": "2026-10-01"
                }
            }
            """;

            var content = new StringContent(jsonBody, Encoding.UTF8, "application/json");

            var response = await _httpClient.PostAsync(Url, content);
            response.EnsureSuccessStatusCode();

            return await response.Content.ReadAsStringAsync();
        }
    }
}
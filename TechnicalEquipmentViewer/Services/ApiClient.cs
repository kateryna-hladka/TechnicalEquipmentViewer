using System;
using System.Collections.Generic;
using System.Linq;
using System.Net.Http;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalEquipmentViewer.Services
{
    public class ApiClient
    {
        HttpClient _httpClient;

        public ApiClient()
        {
            _httpClient = new HttpClient();
        }

        public async Task<string> GetAsync(string url)
        {
            try
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

                var response = await _httpClient.PostAsync(url, content);
                response.EnsureSuccessStatusCode();

                return await response.Content.ReadAsStringAsync();
            }
            catch (HttpRequestException ex)
            {
                throw new ApplicationException($"Error while making POST request to {url}: {ex.Message}", ex);
            }
        }
    }
}

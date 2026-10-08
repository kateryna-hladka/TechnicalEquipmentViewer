using System.Text.Json;
using TechnicalEquipmentViewer.Models;

namespace TechnicalEquipmentViewer.Services
{
    public class JsonService
    {
        public ApiResponse DeserializeResponse(string json)
        {
            return JsonSerializer.Deserialize<ApiResponse>(json)
                ?? throw new InvalidOperationException("Failed to deserialize API response");
        }
    }
}
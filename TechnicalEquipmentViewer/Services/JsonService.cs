using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Text.Json;
using System.Threading.Tasks;
using TechnicalEquipmentViewer.Models;

namespace TechnicalEquipmentViewer.Services
{
    public class JsonService
    {
        public ApiResponse DeserializeResponse(string json)
        {
            return JsonSerializer.Deserialize<ApiResponse>(json)
                ?? throw new ApplicationException("Failed to process the API response");
        }
    }
}

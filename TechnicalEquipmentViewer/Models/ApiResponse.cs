using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalEquipmentViewer.Models
{
    public class ApiResponse
    {
        public string Id { get; set; } = null!;
        public ApiResult Result { get; set; } = null!;
    }
}

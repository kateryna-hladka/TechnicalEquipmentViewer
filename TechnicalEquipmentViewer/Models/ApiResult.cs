using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalEquipmentViewer.Models
{
    public class ApiResult
    {
        public List<TechnicalPlace> TechnicalPlaces { get; set; } = new();
    }
}

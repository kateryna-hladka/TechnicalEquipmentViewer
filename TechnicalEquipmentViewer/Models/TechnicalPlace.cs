using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalEquipmentViewer.Models
{
    public class TechnicalPlace
    {
        public string Name { get; set; } = null!;
        public List<TechnicalPlace> TechnicalPlaces { get; set; } = new();
        public List<Equipment> Equipments { get; set; } = new();
    }
}

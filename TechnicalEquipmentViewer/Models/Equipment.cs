using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TechnicalEquipmentViewer.Models
{
    public class Equipment
    {
        public string Name { get; set; } = null!;
        public List<MonitoringTask> MonitoringTasks { get; set; } = new();
    }
}

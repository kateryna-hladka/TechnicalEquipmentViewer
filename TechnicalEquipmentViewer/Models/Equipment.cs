namespace TechnicalEquipmentViewer.Models
{
    public class Equipment
    {
        public string Name { get; set; } = null!;
        public List<MonitoringTask> MonitoringTasks { get; set; } = new();
    }
}
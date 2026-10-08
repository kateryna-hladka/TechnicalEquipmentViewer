using System;
using System.Collections.Generic;
using System.Linq;
using System.Reflection.PortableExecutable;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Controls;
using TechnicalEquipmentViewer.Models;

namespace TechnicalEquipmentViewer.Services
{
    public class TreeService
    {
        public void AddTechnicalPlaces(ItemCollection parentItems, List<TechnicalPlace> technicalPlaces)
        {
            if (technicalPlaces == null)
            {
                return;
            }

            foreach (TechnicalPlace technicalPlace in technicalPlaces)
            {
                TreeViewItem placeItem = new();

                AddEquipments(placeItem, technicalPlace.Equipments);
                AddTechnicalPlaces(placeItem.Items, technicalPlace.TechnicalPlaces);

                placeItem.Header = $"Technical Place: {technicalPlace.Name}; ({placeItem.Items.Count})";

                parentItems.Add(placeItem);
            }
        }

        private void AddEquipments(TreeViewItem parentItem, List<Equipment> equipments)
        {
            if (equipments == null)
            {
                return;
            }

            foreach (Equipment equipment in equipments)
            {
                TreeViewItem equipmentItem = new();

                AddMonitoringTasks(equipmentItem, equipment.MonitoringTasks);

                equipmentItem.Header = $"Equipment: {equipment.Name}; ({equipmentItem.Items.Count})";

                parentItem.Items.Add(equipmentItem);
            }
        }

        private void AddMonitoringTasks(TreeViewItem parentItem, List<MonitoringTask> tasks)
        {
            if (tasks == null)
            {
                return;
            }

            foreach (MonitoringTask task in tasks)
            {
                parentItem.Items.Add(new TreeViewItem { Header = $"Monitoring Task: {task.CharacteristicName}" });
            }
        }
    }
}
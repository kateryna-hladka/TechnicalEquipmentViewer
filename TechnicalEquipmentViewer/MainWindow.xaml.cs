using System.Windows;
using TechnicalEquipmentViewer.Models;
using TechnicalEquipmentViewer.Services;

namespace TechnicalEquipmentViewer
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();

            LoadDataAsync();
        }

        private async void LoadDataAsync()
        {
            try
            {
                ApiClient apiClient = new();
                JsonService jsonService = new();

                string json = await apiClient.PostAsync();

                ApiResponse response = jsonService.DeserializeResponse(json);

                TreeService treeService = new();
                treeService.AddTechnicalPlaces(TechnicalTree.Items, response.Result.TechnicalPlaces);
            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }
    }
}
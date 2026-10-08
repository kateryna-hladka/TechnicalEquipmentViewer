using System.Text;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;
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

            LoadData();
        }

        private async void LoadData()
        {
            try
            {
                ApiClient apiClient = new();
                JsonService jsonService = new();

                string json = await apiClient.PostAsync("https://it-dev.kovalska.dev/DEV_TOR/ws/api/_MOBILEDATASYNC");

                ApiResponse response = jsonService.DeserializeResponse(json);

                TreeService treeService = new TreeService();
                treeService.AddTechnicalPlaces(TechnicalTree.Items, response.Result.TechnicalPlaces);

            }
            catch (Exception ex)
            {
                MessageBox.Show(ex.Message);
            }
        }


    }
}
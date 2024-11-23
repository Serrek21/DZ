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

namespace DZ
{

    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

        private void CalculateButton_Click(object sender, RoutedEventArgs e)
        {
            WidthInput.Background = Brushes.White;
            HeightInput.Background = Brushes.White;
            double width = 0, height = 0;

            if (double.TryParse(WidthInput.Text, out width) &&
                double.TryParse(HeightInput.Text, out height) &&
                width > 0 && height > 0)
            {
                double area = width * height;
                ResultLabel.Content = area.ToString("F2");
                ResultLabel.Background = Brushes.LightGreen;
            }
            else
            {
                if (!double.TryParse(WidthInput.Text, out _) || width <= 0)
                {
                    WidthInput.Background = Brushes.Red;
                }
                if (!double.TryParse(HeightInput.Text, out _) || height <= 0)
                {
                    HeightInput.Background = Brushes.Red;
                }

                ResultLabel.Content = "Error";
                ResultLabel.Background = Brushes.Pink;
            }
        }
    }
}
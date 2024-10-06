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

namespace abc_taak_01_WPL
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
        }

       
        private void Rood_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush(Colors.Red);
        }

        private void Rood_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));
        }

        private void Geel_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush(Colors.Yellow);
        }

        private void Geel_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));
        }

        private void Groen_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush(Colors.Green);
        }

        private void Groen_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));
        }

        private void Blauw_MouseEnter(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush(Colors.Blue);
        }

        private void Blauw_MouseLeave(object sender, MouseEventArgs e)
        {
            MainWindow1.Background = new SolidColorBrush((Color)ColorConverter.ConvertFromString("#D3D3D3"));
        }

        private void Rood_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeBox.Text = "Rood: #FF0000";
            informatieBox.Text = "Rood is de kleur van warmte";
        }

        private void Geel_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeBox.Text = "Geel: #FFFF00";
            informatieBox.Text = "Geel is de kleur van levenslust";
        }

        private void Groen_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeBox.Text = "Groen: #008000";
            informatieBox.Text = "Groen is de kleur van genezing";
        }

        private void Blauw_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            kleurCodeBox.Text = "Blauw: #0000FF";
            informatieBox.Text = "Blauw is de kleur van intelligentie";
        }
    }
}
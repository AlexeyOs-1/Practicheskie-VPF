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

namespace Practicheskie_VPF
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


        private void changeColor(object sender, RoutedEventArgs e)
        {
            Button button = (Button)sender;
            string colorName = button.Content.ToString();

            // Устанавливаем цвет фона кнопки в соответствии с её содержимым
            switch (colorName)
            {
                case "Красный":
                    button.Background = Brushes.Red;
                    break;
                case "Зеленый":
                    button.Background = Brushes.Green;
                    break;
                case "Синий":
                    button.Background = Brushes.Blue;
                    break;
                case "Желтый":
                    button.Background = Brushes.Yellow;
                    break;
                default:
                    button.Background = Brushes.LightGray;
                    break;
            }
        }

        private void Button_Click(object sender, RoutedEventArgs e)
        {
            this.changeColor(sender, e);
        }

        private void Button_Click_1(object sender, RoutedEventArgs e)
        {
            this.changeColor(sender, e);
        }

        private void Button_Click_2(object sender, RoutedEventArgs e)
        {
            this.changeColor(sender, e);
            
        }

        private void Button_Click_3(object sender, RoutedEventArgs e)
        {
            this.changeColor(sender, e);
        }
    }
}
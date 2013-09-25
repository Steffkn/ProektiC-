using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Navigation;
using System.Windows.Shapes;

namespace LoLClient
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class LoLMainWindow : Window
    {
        public LoLMainWindow()
        {
            InitializeComponent();
            SetBackground(@"source\wow.png");

        }

        private void SetBackground(string fname)
        {
            ImageSourceConverter isource = new ImageSourceConverter();
            ImageBrush brush = new ImageBrush();
            brush.Stretch = Stretch.Fill;
            mainGrid.Background = brush;
            brush.ImageSource = (ImageSource)isource.ConvertFromString(fname);
        }
        private void Window_MouseLeftButtonDown(object sender, MouseButtonEventArgs e)
        {
            this.DragMove();
        }

        private void CloseButton_Click(object sender, RoutedEventArgs e)
        {
            this.Close();
        }

        private void MinimizeButton_Click(object sender, RoutedEventArgs e)
        {
            this.WindowState = WindowState.Minimized;
        }

    }
}

using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading;
using System.Threading.Tasks;
using System.Windows;
using System.Windows.Controls;
using System.Windows.Data;
using System.Windows.Documents;
using System.Windows.Input;
using System.Windows.Media;
using System.Windows.Media.Imaging;
using System.Windows.Shapes;

namespace LoLClient
{
    /// <summary>
    /// Interaction logic for LogoWindow.xaml
    /// </summary>
    public partial class LogoWindow : Window
    {
        public LogoWindow()
        {
            InitializeComponent();

            SetBackground(@"source\logo.png");
            this.Show();
            LoLMainWindow lolMain = new LoLMainWindow();
            Thread.Sleep(2000);
            lolMain.Show();
            this.Close();

        }

        private void SetBackground(string fname)
        {
            ImageSourceConverter isource = new ImageSourceConverter();
            ImageBrush brush = new ImageBrush();
            brush.Stretch = Stretch.Fill;
            logoGrid.Background = brush;
            brush.ImageSource = (ImageSource)isource.ConvertFromString(fname);
        }
    }
}

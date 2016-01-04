using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.InteropServices;
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

namespace _60SecsToAway
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : Window
    {
        public MainWindow()
        {
            InitializeComponent();
            this.Loaded += MainWindow_Loaded;
        }

        [DllImport("User32.dll")]
        private static extern bool SetCursorPos(int X, int Y);

        private async void MainWindow_Loaded(object sender, RoutedEventArgs e)
        {
            int num = 1000;
            while (true)
            {
                SetCursorPos(num, 0);
                await Task.Delay(6000);
                if (num > 0)
                    num -= 100;
                else
                    num = 1000;

            }
        }
        private void SetPosition(int a, int b)
        {
            SetCursorPos(a, b);
        }
    }
}

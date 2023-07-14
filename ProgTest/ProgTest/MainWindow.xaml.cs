using System;
using System.Collections.Generic;
using System.ComponentModel;
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

namespace ProgTest
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

        private void OnKeyDownHandler(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Return)
            {
                txtblHitKey.Text = "ImagineSoftware is a leading provider of medical billing, revenue cycle, and practice management software";
                txtblkEnter.Text = "Exit";
            }
            if (e.Key == Key.Escape)
            {
                txtblHitKey.Text = "Hit the Enter Key";
                txtblkEnter.Text = "Enter";
            }
        }
    }
}

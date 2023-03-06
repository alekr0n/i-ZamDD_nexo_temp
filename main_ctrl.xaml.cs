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
using Telerik.Windows.Controls;

namespace TelerikWpfApp3
{
    public partial class main_ctrl : UserControl
    {
        public main_ctrl()
        {
            InitializeComponent();
        }

        private void RadButtonClik(object sender, System.Windows.RoutedEventArgs e)
        {
            test test = new test();
            test.Show();
        }
    }
}

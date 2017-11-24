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

namespace CCW.Controls
{
    /// <summary>
    /// LinkCardPanelCtrl.xaml 的交互逻辑
    /// </summary>
    public partial class LinkCardPanelCtrl : ListBoxItem
    {
        public LinkCardPanelCtrl()
        {
            InitializeComponent();
            this.name.Text = "xxx";
            this.mobile2.Visibility = Visibility.Collapsed;
        }

        private void topButton_Click(object sender, RoutedEventArgs e)
        {
            MessageBox.Show("topButton");
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mobile1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void mobile2_Click(object sender, RoutedEventArgs e)
        {

        }

        private void phone1_Click(object sender, RoutedEventArgs e)
        {

        }

        private void phone2_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

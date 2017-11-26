using CCW.Models;
using MahApps.Metro.Controls.Dialogs;
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
        private LinkCardModel linkCardModel;
        IDialogCoordinator dialogCoordinator= DialogCoordinator.Instance;
        // Here we create the viewmodel with the current DialogCoordinator instance 

        public LinkCardPanelCtrl()
        {
            InitializeComponent();
        }
        public LinkCardPanelCtrl(LinkCardModel model)
        {
            InitializeComponent();
            this.linkCardModel = model;
            model.DialogCoordinator = dialogCoordinator;
            this.DataContext = model;
            if (string.IsNullOrWhiteSpace(model.Mobile2))
            {
                this.mobile2.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrWhiteSpace(model.Phone1))
            {
                phone1.Visibility = Visibility.Collapsed;
            }
            if (string.IsNullOrWhiteSpace(model.Phone2))
            {
                phone2.Visibility = Visibility.Collapsed;
            }
            name.Text = model.Name;
        }

        private void topButton_Click(object sender, RoutedEventArgs e)
        {
            //dialogCoordinator.ShowMessageAsync("123", "tip", "1234").Wait();
            this.linkCardModel.Top();
        }

        private void moveButton_Click(object sender, RoutedEventArgs e)
        {

        }

        private void editButton_Click(object sender, RoutedEventArgs e)
        {
            var linkCardWindow = new LinkCardDetailWindow();
            linkCardWindow.ShowDialog();
        }

        private void mobile1_Click(object sender, RoutedEventArgs e)
        {
            CallOut(linkCardModel.Mobile1);
        }

        private void mobile2_Click(object sender, RoutedEventArgs e)
        {
            CallOut(linkCardModel.Mobile2);
        }

        private void phone1_Click(object sender, RoutedEventArgs e)
        {
            CallOut(linkCardModel.Phone1);
        }

        private void phone2_Click(object sender, RoutedEventArgs e)
        {
            CallOut(linkCardModel.Phone2);
        }
        private void CallOut(String callout)
        {
            if (!String.IsNullOrWhiteSpace(callout))
            {
                MessageBox.Show(callout);
            }
        }
    }
}

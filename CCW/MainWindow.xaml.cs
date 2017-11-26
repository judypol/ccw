using CCW.Controls;
using MahApps.Metro.Controls;
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
using GongSolutions.Wpf.DragDrop;

namespace CCW
{
    /// <summary>
    /// MainWindow.xaml 的交互逻辑
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();
            AddOneTab("tab1");
            AddOneTab("tab2");

            this.tab_linkCard.SelectedIndex = 0;

            this.tab_linkCard.SelectionChanged += Tab_linkCard_SelectionChanged;
            
        }

        private void Tab_linkCard_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {
            if(e.Source is TabControl)
            {
                RefreshSelectedTab();
            }
            
            //throw new NotImplementedException();
        }
        #region MyRegion
        private void AddOneTab(String groupName)
        {
            MetroTabItem metroTabItem = new MetroTabItem();
            metroTabItem.Name = groupName;
            metroTabItem.Header = groupName;
            metroTabItem.CloseButtonEnabled = true;

            ListBox listBox = new ListBox();
            listBox.Margin = new Thickness(2);
            //GongSolutions.Wpf.DragDrop.DragDrop.SetDragHandler();
            GongSolutions.Wpf.DragDrop.DragDrop.SetIsDragSource(listBox, true);
            GongSolutions.Wpf.DragDrop.DragDrop.SetIsDropTarget(listBox, true);
            GongSolutions.Wpf.DragDrop.DragDrop.SetDropTargetAdornerBrush(listBox, new SolidColorBrush(Colors.Coral));
            metroTabItem.Content = listBox;
            
            this.tab_linkCard.Items.Add(metroTabItem);
        }
        private void RefreshSelectedTab()
        {
            var curTab = (MetroTabItem)this.tab_linkCard.SelectedItem;
            if (curTab == null)
                return;
            var listBox = (ListBox)curTab.Content;

            listBox.Items.Add(new LinkCardPanelCtrl(new Models.LinkCardModel {
                Name="lisi",
                Mobile1="13818894125"
            }));
            listBox.Items.Add(new LinkCardPanelCtrl(new Models.LinkCardModel {
                Name="展示2",
                Mobile1="14589781245",
                Phone1="13978457845",
                Phone2="45127844557"
            }));
            listBox.Items.Add(new LinkCardPanelCtrl(new Models.LinkCardModel {
                Name = "展示1",
                Phone1 = "13978457845",
                Phone2 = "45127844557",
                Mobile1="457894568745"
            }));
            listBox.Items.Add(new LinkCardPanelCtrl(new Models.LinkCardModel {
                Name = "展示4323",
                Phone1 = "13978457845",
                Phone2 = "45127844557",
                Mobile1 = "457894568745",
                Mobile2="13546879478"
            }));
        }
        #endregion


        private void txt_callout_KeyDown(object sender, KeyEventArgs e)
        {
            if (e.Key == Key.Enter)
            {
                var ss=this.txt_callout.Text;
            }
        }

        private void cb_SelectionChanged(object sender, SelectionChangedEventArgs e)
        {

        }

        private void btn_callout_Click(object sender, RoutedEventArgs e)
        {

        }
    }
}

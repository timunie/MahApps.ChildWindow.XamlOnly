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
using MahApps.Metro.Controls;
using MahApps.Metro.SimpleChildWindow;
using ChWindowViaXaml.ChildWindows;

namespace ChWindowViaXaml
{
    /// <summary>
    /// Interaction logic for MainWindow.xaml
    /// </summary>
    public partial class MainWindow : MetroWindow
    {
        public MainWindow()
        {
            InitializeComponent();






        }


        // ChdWindow1 instance
        ChWindow1 _chwindow1 = new ChWindow1() { IsModal = false, AllowMove = true, IsOpen = false };

        // ChWindow call via event
        private async void Button_Click(object sender, RoutedEventArgs e)
        {


            await this.ShowChildWindowAsync(_chwindow1, RootGrid);



        }



    }
}

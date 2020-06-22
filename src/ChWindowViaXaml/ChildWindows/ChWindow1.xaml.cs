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

namespace ChWindowViaXaml.ChildWindows
{
    /// <summary>
    /// Interaction logic for ChWindow1.xaml
    /// </summary>
    public partial class ChWindow1 : ChildWindow
    {
        public ChWindow1()
        {
            InitializeComponent();

            
        }

        private async void ShowAnotherChildWindow_Click(object sender, RoutedEventArgs e)
        {
            // try to get the parent window
            var parent = this.TryFindParent<MetroWindow>();

            if (parent != null)
            {
                await parent.ShowChildWindowAsync(new ChildWindow()
                {
                    Content = "It works :-)",
                    Title = "Test",
                    CloseByEscape = true,
                    ShowCloseButton = true,
                    CloseOnOverlay = true,
                    Padding = new Thickness(10)
                });
            }
        }
    }
}

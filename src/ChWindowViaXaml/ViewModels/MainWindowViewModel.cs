using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ChWindowViaXaml.ChildWindows;
using MahApps.Metro.Controls;
using MahApps.Metro.SimpleChildWindow;

namespace ChWindowViaXaml.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {

        public MainWindowViewModel()
        {
            // Define this in the constructor because then you can access local Methods as well.
            OpenChWindow1 = new SimpleCommand((param) => { ExecuteOpenChWindow1(param); });
        }


        // OpenChWindow1 command definition     
        public SimpleCommand OpenChWindow1 { get; } 

        // Let's provide the window where to render the ChildWindow as a parameter
        private void ExecuteOpenChWindow1(object param)
        {
            if (param is MetroWindow window)
            {
                ChWindow1_VM _chWindow1_VM = new ChWindow1_VM();

                window.ShowChildWindowAsync(new ChWindow1() { DataContext = _chWindow1_VM });
            }

           



        }








    }
}

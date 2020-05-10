using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;
using GalaSoft.MvvmLight.CommandWpf;
using ChWindowViaXaml.ChildWindows;

namespace ChWindowViaXaml.ViewModels
{
    public class MainWindowViewModel: ViewModelBase
    {


        // OpenChWindow1 command definition
        private RelayCommand _openChWindow1;       
        public RelayCommand OpenChWindow1
        {
            get
            {
                return _openChWindow1
                    ?? (_openChWindow1 = new RelayCommand(ExecuteOpenChWindow1));
            }
        }

        private void ExecuteOpenChWindow1()
        {

            ChWindow1_VM _chWindow1_VM = new ChWindow1_VM();
            if (_chWindow1_VM != null)
                _chWindow1_VM.ChWindow1OpenClose = true;



        }








    }
}

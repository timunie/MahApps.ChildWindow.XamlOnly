using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using GalaSoft.MvvmLight;

namespace ChWindowViaXaml.ChildWindows
{
    public class ChWindow1_VM: ViewModelBase
    {

        public const string ChWindow1OpenClosePropertyName = "ChWindow1OpenClose";

        private bool _chWindow1OpenClose = false;
        public bool ChWindow1OpenClose
        {
            get
            {
                return _chWindow1OpenClose;
            }

            set
            {
                if (_chWindow1OpenClose == value)
                {
                    return;
                }

                _chWindow1OpenClose = value;
                RaisePropertyChanged(ChWindow1OpenClosePropertyName);
            }
        }








    }
}

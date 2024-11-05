using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class SecondViewModel: BaseViewModel
    {
        public RelayCommand FirstButtonCommand { get; set; }
        public RelayCommand ThirdButtonCommand { get; set; }

        public event EventHandler<int> ChangePage;

        public SecondViewModel()
        {
            FirstButtonCommand = new RelayCommand(GotoPage1);
            ThirdButtonCommand = new RelayCommand(GotoPage3);
            Title = "2de view";
        }

        private void GotoPage3()
        {
            ChangePage(this, 3);
        }

        private void GotoPage1()
        {
            ChangePage(this, 1);
        }
    }
}

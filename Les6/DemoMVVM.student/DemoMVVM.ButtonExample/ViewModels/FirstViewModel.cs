using Odisee.Common;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Media;

namespace DemoMVVM.ButtonExample.ViewModels
{
    class FirstViewModel: BaseViewModel
    {
        public RelayCommand SecondButtonCommand { get; set; }
        public RelayCommand ThirdButtonCommand { get; set; }

        public event EventHandler<int> ChangePage;

        public Brush SelectedColor { get; set; } = Brushes.Red;

        public FirstViewModel()
        {
            SecondButtonCommand = new RelayCommand(GotoPage2);
            ThirdButtonCommand = new RelayCommand(GotoPage3);
            Title = "Eerste view";
        }

        private void GotoPage3()
        {
            ChangePage(this, 3);
        }

        private void GotoPage2()
        {
            ChangePage(this, 2);
        }
    }
}
